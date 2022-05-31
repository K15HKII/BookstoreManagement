using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface ILendRepository
{
    #region Lend
    [Get("/api/model/lend")]
    IObservable<List<Lend>> getListLend();

    [Get("/api/model/lend")]
    IObservable<Lend> getLend(string id);

    [Post("/api/model/lend")]
    IObservable<Object> saveLend(Lend lend);

    [Delete("/api/model/lend")]
    IObservable<Object> deleteLend(string id);
    #endregion
}