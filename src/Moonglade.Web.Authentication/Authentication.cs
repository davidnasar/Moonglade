﻿namespace Moonglade.Web.Authentication
{
    public class Authentication
    {
        public AuthenticationProvider Provider { get; set; }

        public AzureAdOption AzureAd { get; set; }

        public LocalAccountOption Local { get; set; }

        public Authentication()
        {
            Provider = AuthenticationProvider.None;
        }
    }
}