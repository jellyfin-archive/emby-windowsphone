﻿using GalaSoft.MvvmLight.Messaging;

namespace Emby.WindowsPhone.Messaging
{
    public class RemoteMessage : MessageBase
    {
        public RemoteMessage(string itemId, long? startPositionTicks)
        {
            ItemId = itemId;
            StartPositionTicks = startPositionTicks;
        }

        public string ItemId { get; set; }
        public long? StartPositionTicks { get; set; }
    }
}