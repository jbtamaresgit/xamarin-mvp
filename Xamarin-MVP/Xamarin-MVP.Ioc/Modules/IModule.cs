﻿namespace Xamarin_MVP.Ioc.Modules
{
    public interface IModule
    {
        void RegisterType(IContainerRegistry containerRegistry);
        void OnInitialized(IContainerProvider containerProvider);
    }
}
