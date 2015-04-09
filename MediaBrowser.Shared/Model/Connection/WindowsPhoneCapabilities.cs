﻿using MediaBrowser.Model.Dlna;
using MediaBrowser.Model.Session;

namespace Emby.WindowsPhone.Model.Connection
{
    public static class WindowsPhoneCapabilities
    {
        public static ClientCapabilities Audio
        {
            get { return CreateCapabilities(false, false, false); }
        }

        public static ClientCapabilities Photos
        {
            get { return CreateCapabilities(false, true, false); }
        }

        public static ClientCapabilities App(DeviceProfile profile = null)
        {
            return CreateCapabilities(false, true, true, profile); 
        }

        public static ClientCapabilities CreateCapabilities(bool supportsPlayback, bool supportsContentUpload, bool supportsSync, DeviceProfile profile = null)
        {
            return new ClientCapabilities
            {
                SupportsMediaControl = supportsPlayback,
                SupportsContentUploading = supportsContentUpload,
                SupportsSync = supportsSync,
                SupportsOfflineAccess = supportsSync,
                DeviceProfile = supportsSync && profile != null ? profile : null
            };
        }
    }
}
