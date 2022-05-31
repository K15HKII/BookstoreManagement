using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface IBillRepository
{
    #region Bill
    [Get("/api/model/bill")]
    IObservable<List<Bill>> getListBill();

    [Get("/api/model/bill")]
    IObservable<Bill> getBill(int id);

    [Post("/api/model/bill")]
    IObservable<Object> saveBill(Bill bill);

    [Delete("/api/model/bill")]
    IObservable<Object> deleteBill(int id);
    #endregion
}