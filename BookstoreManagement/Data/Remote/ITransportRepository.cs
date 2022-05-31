using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface ITransportRepository
{
    #region Transport
    [Get("/api/model/transport")]
    IObservable<List<Transport>> getListTransport();

    [Get("/api/model/transport")]
    IObservable<Transport> getTransport(string id);

    [Post("/api/model/transport")]
    IObservable<Object> saveTransport(Transport transport);

    [Delete("/api/model/transport")]
    IObservable<Object> deleteTransport(string id);
    #endregion
}