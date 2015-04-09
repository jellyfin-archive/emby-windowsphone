﻿using Emby.WindowsPhone.Interfaces;
using Emby.WindowsPhone.Services;
using MediaBrowser.Model.Configuration;
using MediaBrowser.Model.Dto;
using MediaBrowser.Model.LiveTv;
using MediaBrowser.Model.System;
using PropertyChanged;

namespace Emby.WindowsPhone.Model
{
    [ImplementPropertyChanged]
    public class SettingsService : ISettingsService
    {
        public UserDto LoggedInUser
        {
            get
            {
                return AuthenticationService.Current.LoggedInUser;
            }
        }

        public ConnectionDetails ConnectionDetails { get; set; }
        public ServerConfiguration ServerConfiguration { get; set; }
        public PublicSystemInfo SystemStatus { get; set; }
        public LiveTvInfo LiveTvInfo { get; set; }
    }
}
