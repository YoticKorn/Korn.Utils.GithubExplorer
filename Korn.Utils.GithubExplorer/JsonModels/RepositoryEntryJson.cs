﻿using Newtonsoft.Json;

namespace Korn.Utils.GithubExplorer;
/* Autogenerated by: https://github.com/Yoticc/JsonMappingsGenerator */
public record RepositoryEntryJson(
    [JsonProperty("name")] string Name,
    [JsonProperty("path")] string Path,
    [JsonProperty("sha")] string Sha,
    [JsonProperty("size")] long Size,
    [JsonProperty("url")] string Url,
    [JsonProperty("html_url")] string HtmlUrl,
    [JsonProperty("git_url")] string GitUrl,
    [JsonProperty("download_url")] object DownloadUrl,
    [JsonProperty("type")] string Type,
    [JsonProperty("_links")] RepositoryEntryJson.LinksData Links)
{
    public record LinksData(
        [JsonProperty("self")] string Self,
        [JsonProperty("git")] string Git,
        [JsonProperty("html")] string Html);
}