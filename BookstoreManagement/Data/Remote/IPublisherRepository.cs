﻿using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface IPublisherRepository
{
    #region Publisher
    [Get("/api/publisher")]
    IObservable<List<Publisher>> GetPublishers();

    [Get("/api/publisher")]
    IObservable<Publisher> GetPublisher(int id);

    [Post("/api/publisher")]
    IObservable<Publisher> CreatePublisher(PublisherUpdateRequest request);
    
    [Put("/api/publisher/{id}")]
    IObservable<Publisher> UpdatePublisher(int id, [Body] Publisher publisher);

    [Delete("/api/publisher")]
    IObservable<Object> DeletePublisher(int id);
    #endregion
}