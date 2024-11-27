using Newtonsoft.Json;

namespace Korn.Utils.GithubExplorer;
public class GithubClient
{
    public GithubClient(HttpClient client)
    {
        HttpClient = client;

        var headers = client.DefaultRequestHeaders;
        headers.Add("Accept", "application/vnd.github+json");
        headers.Add("X-GitHub-Api-Version", "2022-11-28");
        headers.Add("User-Agent", "null");
    }

    public GithubClient() : this(new HttpClient()) { }

    public readonly HttpClient HttpClient;

    HttpRequestMessage CreateGetRequest(string url)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        return request;
    }

    public List<ReleaseJson> GetReleases(RepositoryID repository)
    {
        using var request = CreateGetRequest($"https://api.github.com/repos/{repository.Owner}/{repository.Name}/releases");
        
        var response = HttpClient.Send(request);

        var data = new StreamReader(response.Content.ReadAsStream()).ReadToEnd();
        var result = JsonConvert.DeserializeObject<List<ReleaseJson>>(data)!;

        return result;
    }
}