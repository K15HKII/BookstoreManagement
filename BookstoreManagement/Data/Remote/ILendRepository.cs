using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface ILendRepository
{
    #region Lend
    [Get("/api/lend/search")]
    IObservable<List<Lend>> GetLends();

    [Get("/api/lend/{id}")]
    IObservable<Lend> GetLend([AliasAs("id")] string id);

    [Post("/api/lend/{id}")]
    IObservable<Object> SaveLend([AliasAs("id")] string id, Lend lend);

    [Delete("/api/lend/{id}")]
    IObservable<Object> DeleteLend([AliasAs("id")] string id);
    #endregion
}