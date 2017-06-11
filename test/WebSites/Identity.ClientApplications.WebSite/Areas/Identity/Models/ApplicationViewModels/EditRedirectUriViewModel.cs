﻿namespace Identity.ClientApplications.WebSite
{
    public class EditRedirectUriViewModel
    {
        public EditRedirectUriViewModel()
        {
        }

        public EditRedirectUriViewModel(string applicationName, string redirectUri)
        {
            Name = applicationName;
            RedirectUri = redirectUri;
        }

        public string Name { get; }
        public string RedirectUri { get; set; }
    }
}
