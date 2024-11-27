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

    T SendSimpleGetRequest<T>(string url)
    {
        using var request = CreateGetRequest(url);

        var response = HttpClient.Send(request);

        var data = new StreamReader(response.Content.ReadAsStream()).ReadToEnd();
        var result = JsonConvert.DeserializeObject<T>(data)!;

        return result;
    }

    public List<RepositoryReleaseJson> GetRepositoryReleases(RepositoryID repository) 
        => SendSimpleGetRequest<List<RepositoryReleaseJson>>($"https://api.github.com/repos/{repository.Owner}/{repository.Name}/releases");

    public List<RepositoryEntryJson> GetRepositoryEntry(RepositoryID repository, string? path = null)
        => SendSimpleGetRequest<List<RepositoryEntryJson>>($"https://api.github.com/repos/{repository.Owner}/{repository.Name}/contents{(path is null ? "" : $"/{path}")}");
}