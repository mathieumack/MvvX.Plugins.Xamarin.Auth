﻿using MvvmCross;
using MvvmCross.Plugin;

namespace MvvX.Plugins.IOAuthClient.Touch
{
    [MvxPlugin]
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.IoCProvider.RegisterSingleton<IOAuthClient>(new PlatformOAuthClient());
        }
    }
}
