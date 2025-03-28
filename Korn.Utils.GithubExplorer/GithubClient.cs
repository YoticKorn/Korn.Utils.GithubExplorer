﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System;
using System.Text;

namespace Korn.Utils.GithubExplorer 
{
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
            try
            {
                using (var request = CreateGetRequest(url))
                {
                    var response = HttpClient.SendAsync(request).GetAwaiter().GetResult();

                    var data = response.Content.ReadAsByteArrayAsync().GetAwaiter().GetResult();
                    var result = JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(data));

                    return result;
                }                    
            }
            catch (Exception ex)
            {
                throw new KornException("GithubClient->SendSimpleGetRequest<T>(string): Failed to send an request.", ex);
            }
        }

        public List<RepositoryReleaseJson> GetRepositoryReleases(RepositoryID repository)
            => SendSimpleGetRequest<List<RepositoryReleaseJson>>($"https://api.github.com/repos/{repository.Owner}/{repository.Name}/releases");

        public List<RepositoryEntryJson> GetRepositoryEntries(RepositoryID repository, string path = null)
            => SendSimpleGetRequest<List<RepositoryEntryJson>>($"https://api.github.com/repos/{repository.Owner}/{repository.Name}/contents{(path is null ? "" : $"/{path}")}");

        byte[] DownloadAsset(string url)
        {
            using (var request = CreateGetRequest(url))
            {
                var response = HttpClient.SendAsync(request).GetAwaiter().GetResult();
                var bytes = response.Content.ReadAsByteArrayAsync().GetAwaiter().GetResult();

                return bytes;
            }            
        }

        public byte[] DownloadAsset(RepositoryReleaseJson.Asset asset) => DownloadAsset(asset.BrowserDownloadUrl);

        public byte[] DownloadAsset(RepositoryEntryJson asset)
        {
            if (asset.Type != "file")
                throw new KornError("GithubClient->DownloadAsset: The asset is not a file.");

            return DownloadAsset(asset.GetDownloadUrl());
        }
    }
}