﻿using Newtonsoft.Json;

namespace Korn.Utils.GithubExplorer;
/* Autogenerated by: https://github.com/Yoticc/JsonMappingsGenerator */
public record RepositoryReleaseJson(
    [JsonProperty("url")] string Url,
    [JsonProperty("assets_url")] string AssetsUrl,
    [JsonProperty("upload_url")] string UploadUrl,
    [JsonProperty("html_url")] string HtmlUrl,
    [JsonProperty("id")] long Id,
    [JsonProperty("author")] RepositoryReleaseJson.AuthorData Author,
    [JsonProperty("node_id")] string NodeId,
    [JsonProperty("tag_name")] string TagName,
    [JsonProperty("target_commitish")] string TargetCommitish,
    [JsonProperty("name")] string Name,
    [JsonProperty("draft")] bool Draft,
    [JsonProperty("prerelease")] bool Prerelease,
    [JsonProperty("created_at")] DateTime CreatedAt,
    [JsonProperty("published_at")] DateTime PublishedAt,
    [JsonProperty("assets")] RepositoryReleaseJson.Asset[] Assets,
    [JsonProperty("tarball_url")] string TarballUrl,
    [JsonProperty("zipball_url")] string ZipballUrl,
    [JsonProperty("body")] string Body)
{
    public record Asset(
    [JsonProperty("url")] string Url,
    [JsonProperty("id")] long Id,
    [JsonProperty("node_id")] string NodeId,
    [JsonProperty("name")] string Name,
    [JsonProperty("label")] object Label,
    [JsonProperty("uploader")] Asset.UploaderData Uploader,
    [JsonProperty("content_type")] string ContentType,
    [JsonProperty("state")] string State,
    [JsonProperty("size")] int Size,
    [JsonProperty("download_count")] int DownloadCount,
    [JsonProperty("created_at")] DateTime CreatedAt,
    [JsonProperty("updated_at")] DateTime UpdatedAt,
    [JsonProperty("browser_download_url")] string BrowserDownloadUrl)
    {
        public record UploaderData(
            [JsonProperty("login")] string Login,
            [JsonProperty("id")] long Id,
            [JsonProperty("node_id")] string NodeId,
            [JsonProperty("avatar_url")] string AvatarUrl,
            [JsonProperty("gravatar_id")] string GravatarId,
            [JsonProperty("url")] string Url,
            [JsonProperty("html_url")] string HtmlUrl,
            [JsonProperty("followers_url")] string FollowersUrl,
            [JsonProperty("following_url")] string FollowingUrl,
            [JsonProperty("gists_url")] string GistsUrl,
            [JsonProperty("starred_url")] string StarredUrl,
            [JsonProperty("subscriptions_url")] string SubscriptionsUrl,
            [JsonProperty("organizations_url")] string OrganizationsUrl,
            [JsonProperty("repos_url")] string ReposUrl,
            [JsonProperty("events_url")] string EventsUrl,
            [JsonProperty("received_events_url")] string ReceivedEventsUrl,
            [JsonProperty("type")] string Type,
            [JsonProperty("user_view_type")] string UserViewType,
            [JsonProperty("site_admin")] bool SiteAdmin);
    }

    public record AuthorData(
        [JsonProperty("login")] string Login,
        [JsonProperty("id")] long Id,
        [JsonProperty("node_id")] string NodeId,
        [JsonProperty("avatar_url")] string AvatarUrl,
        [JsonProperty("gravatar_id")] string GravatarId,
        [JsonProperty("url")] string Url,
        [JsonProperty("html_url")] string HtmlUrl,
        [JsonProperty("followers_url")] string FollowersUrl,
        [JsonProperty("following_url")] string FollowingUrl,
        [JsonProperty("gists_url")] string GistsUrl,
        [JsonProperty("starred_url")] string StarredUrl,
        [JsonProperty("subscriptions_url")] string SubscriptionsUrl,
        [JsonProperty("organizations_url")] string OrganizationsUrl,
        [JsonProperty("repos_url")] string ReposUrl,
        [JsonProperty("events_url")] string EventsUrl,
        [JsonProperty("received_events_url")] string ReceivedEventsUrl,
        [JsonProperty("type")] string Type,
        [JsonProperty("user_view_type")] string UserViewType,
        [JsonProperty("site_admin")] bool SiteAdmin);
}
