using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface IPublisherRepository
{
    #region Publisher
    [Get("/api/model/publisher")]
    IObservable<List<Publisher>> getListPublisher();

    [Get("/api/model/publisher")]
    IObservable<Publisher> getPublisher(int id);

    [Post("/api/model/publisher")]
    IObservable<Object> savePublisher(Publisher publisher);

    [Delete("/api/model/publisher")]
    IObservable<Object> deletePublisher(int id);
    #endregion
}