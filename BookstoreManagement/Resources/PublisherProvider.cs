using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using BookstoreManagement.Data.Model.Api;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace BookstoreManagement.Resources;

public class PublisherProvider
{

    private IModelRemote? _modelRemote;
    private ScheluderProvider? _scheluder;

    public List<Publisher> Source
    {
        get
        {
            IServiceProvider service = ((App) App.Current).ServiceProvider;
            if (_modelRemote == null)
                _modelRemote = service.GetRequiredService<IModelRemote>();
            if (_scheluder == null)
                _scheluder = service.GetRequiredService<ScheluderProvider>();
            return _modelRemote.GetPublishers()
                .SubscribeOn(_scheluder.IO())
                .Wait();
        }
    }
}