﻿namespace Identity.ClientApplications.WebSite
{
    public class EditLogoutUriViewModel
    {
        public EditLogoutUriViewModel()
        {
        }

        public EditLogoutUriViewModel(string applicationName, string logoutUri)
        {
            Name = applicationName;
            LogoutUri = logoutUri;
        }

        public string Name { get; }
        public string LogoutUri { get; set; }
    }
}
