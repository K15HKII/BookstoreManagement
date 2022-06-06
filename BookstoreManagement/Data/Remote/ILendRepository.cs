using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface ILendRepository
{
    #region Lend
    [Get("/api/lend")]
    IObservable<List<Lend>> getListLend();

    [Get("/api/lend")]
    IObservable<Lend> getLend(string id);

    [Post("/api/lend")]
    IObservable<Object> saveLend(Lend lend);

    [Delete("/api/lend")]
    IObservable<Object> deleteLend(string id);
    #endregion
}