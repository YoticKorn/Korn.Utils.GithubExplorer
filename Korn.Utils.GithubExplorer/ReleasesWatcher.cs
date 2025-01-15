namespace Korn.Utils.GithubExplorer;
public class ReleasesWatcher : IDisposable
{
    public ReleasesWatcher(GithubClient client, RepositoryID repository)
    {
        Client = client;
        Repository = repository;

        Watch();
    }

    public readonly GithubClient Client;
    public readonly RepositoryID Repository;
    public TimeSpan WatchDelay = TimeSpan.FromSeconds(30);

    public delegate void ReleaseArrivedDelegate(RepositoryReleaseJson release);
    public event ReleaseArrivedDelegate? ReleaseArrived;

    bool watcherStarted;
    public void StartHandle()
    {
        if (watcherStarted)
            throw new KornError("ReleasesWatcher->StartHandle: Handling is already started.");

        watcherStarted = true;

        new Thread(Handler).Start();

        void Handler()
        {
            while (!isDisposed)
            {
                Thread.Sleep(WatchDelay);
                Watch();
            }
        }
    }

    public List<RepositoryReleaseJson> LastWatchedReleases
    {
        get
        {
            if (releases is null)
                Watch();

            return releases!;
        }
    }

    List<RepositoryReleaseJson>? releases;
    void Watch()
    {
        var newReleases = Client.GetRepositoryReleases(Repository);

        if (newReleases is null)
            throw new KornError("ReleasesWatcher->Watch: Unable to fetch the repository releases.");

        if (releases is not null)
        {
            if (newReleases.Count != releases.Count)
            {
                if (newReleases.Count > releases.Count)
                {
                    var arrivedRelease = newReleases[0];
                    ReleaseArrived?.Invoke(arrivedRelease);
                }
            }
        }

        releases = newReleases;
    }

    bool isDisposed;
    public void Dispose() => isDisposed = true;
    ~ReleasesWatcher() => Dispose();
}