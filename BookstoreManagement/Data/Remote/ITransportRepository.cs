using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface ITransportRepository
{
    #region Transport
    [Get("/api/transport")]
    IObservable<List<Transport>> getListTransport();

    [Get("/api/transport")]
    IObservable<Transport> getTransport(string id);

    [Post("/api/transport")]
    IObservable<Object> saveTransport(Transport transport);

    [Delete("/api/transport")]
    IObservable<Object> deleteTransport(string id);
    #endregion
}