﻿using Newtonsoft.Json;
using System;

namespace Korn.Utils.GithubExplorer
{
    /* Autogenerated by: https://github.com/Yoticc/JsonMappingsGenerator */
    public class RepositoryReleaseJson
    {
        [JsonProperty("url")] public string Url;
        [JsonProperty("assets_url")] public string AssetsUrl;
        [JsonProperty("upload_url")] public string UploadUrl;
        [JsonProperty("html_url")] public string HtmlUrl;
        [JsonProperty("id")] public long Id;
        [JsonProperty("author")] public AuthorData Author;
        [JsonProperty("node_id")] public string NodeId;
        [JsonProperty("tag_name")] public string TagName;
        [JsonProperty("target_commitish")] public string TargetCommitish;
        [JsonProperty("name")] public string Name;
        [JsonProperty("draft")] public bool Draft;
        [JsonProperty("prerelease")] public bool Prerelease;
        [JsonProperty("created_at")] public DateTime CreatedAt;
        [JsonProperty("published_at")] public DateTime PublishedAt;
        [JsonProperty("assets")] public Asset[] Assets;
        [JsonProperty("tarball_url")] public string TarballUrl;
        [JsonProperty("zipball_url")] public string ZipballUrl;
        [JsonProperty("body")] public string Body;

        public class Asset
        {
            [JsonProperty("url")] public string Url;
            [JsonProperty("id")] public long Id;
            [JsonProperty("node_id")] public string NodeId;
            [JsonProperty("name")] public string Name;
            [JsonProperty("label")] public object Label;
            [JsonProperty("uploader")] public UploaderData Uploader;
            [JsonProperty("content_type")] public string ContentType;
            [JsonProperty("state")] public string State;
            [JsonProperty("size")] public int Size;
            [JsonProperty("download_count")] public int DownloadCount;
            [JsonProperty("created_at")] public DateTime CreatedAt;
            [JsonProperty("updated_at")] public DateTime UpdatedAt;
            [JsonProperty("browser_download_url")] public string BrowserDownloadUrl;

            public class UploaderData
            {
                [JsonProperty("login")] public string Login;
                [JsonProperty("id")] public long Id;
                [JsonProperty("node_id")] public string NodeId;
                [JsonProperty("avatar_url")] public string AvatarUrl;
                [JsonProperty("gravatar_id")] public string GravatarId;
                [JsonProperty("url")] public string Url;
                [JsonProperty("html_url")] public string HtmlUrl;
                [JsonProperty("followers_url")] public string FollowersUrl;
                [JsonProperty("following_url")] public string FollowingUrl;
                [JsonProperty("gists_url")] public string GistsUrl;
                [JsonProperty("starred_url")] public string StarredUrl;
                [JsonProperty("subscriptions_url")] public string SubscriptionsUrl;
                [JsonProperty("organizations_url")] public string OrganizationsUrl;
                [JsonProperty("repos_url")] public string ReposUrl;
                [JsonProperty("events_url")] public string EventsUrl;
                [JsonProperty("received_events_url")] public string ReceivedEventsUrl;
                [JsonProperty("type")] public string Type;
                [JsonProperty("user_view_type")] public string UserViewType;
                [JsonProperty("site_admin")] public bool SiteAdmin;
            }
        }

        public class AuthorData
        {
            [JsonProperty("login")] public string Login;
            [JsonProperty("id")] public long Id;
            [JsonProperty("node_id")] public string NodeId;
            [JsonProperty("avatar_url")] public string AvatarUrl;
            [JsonProperty("gravatar_id")] public string GravatarId;
            [JsonProperty("url")] public string Url;
            [JsonProperty("html_url")] public string HtmlUrl;
            [JsonProperty("followers_url")] public string FollowersUrl;
            [JsonProperty("following_url")] public string FollowingUrl;
            [JsonProperty("gists_url")] public string GistsUrl;
            [JsonProperty("starred_url")] public string StarredUrl;
            [JsonProperty("subscriptions_url")] public string SubscriptionsUrl;
            [JsonProperty("organizations_url")] public string OrganizationsUrl;
            [JsonProperty("repos_url")] public string ReposUrl;
            [JsonProperty("events_url")] public string EventsUrl;
            [JsonProperty("received_events_url")] public string ReceivedEventsUrl;
            [JsonProperty("type")] public string Type;
            [JsonProperty("user_view_type")] public string UserViewType;
            [JsonProperty("site_admin")] public bool SiteAdmin;
        }
    }
}
