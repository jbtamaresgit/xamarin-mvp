﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using Android.App;
using Xamarin_MVP.Common.Entities;
using Xamarin_MVP.Common.List;

namespace Xamarin_MVP.Android.Adapter
{
    public class ListAdapter : ItemsAdapter<StoreEntity>
    {
        readonly ListPresenter presenter;

        public ListAdapter(Activity activity, ObservableCollection<StoreEntity> collection) : base(activity, collection)
        {
            this.presenter.CollectionOfStore.CollectionChanged += (sender, args) =>
            {
                activity.RunOnUiThread(NotifyDataSetChanged);
            };
        }

        public override int GetResourceLayoutId()
        {
            return Resource.Layout.ListItem;
        }
    }
}