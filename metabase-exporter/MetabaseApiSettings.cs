﻿using System;

namespace metabase_exporter
{
    public class MetabaseApiSettings
    {
        public Uri MetabaseApiUrl { get; }
        public string MetabaseApiUsername { get; }
        public string MetabaseApiPassword { get; }

        public MetabaseApiSettings(Uri metabaseApiUrl, string metabaseApiUsername, string metabaseApiPassword)
        {
            MetabaseApiUrl = metabaseApiUrl;
            MetabaseApiUsername = metabaseApiUsername;
            MetabaseApiPassword = metabaseApiPassword;
        }
    }
}
