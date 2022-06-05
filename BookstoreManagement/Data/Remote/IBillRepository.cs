using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface IBillRepository
{
    #region Bill
    [Get("/api/bill")]
    IObservable<List<Bill>> getListBill();

    [Get("/api/bill")]
    IObservable<Bill> getBill(int id);

    [Post("/api/bill")]
    IObservable<Object> saveBill(Bill bill);

    [Delete("/api/bill")]
    IObservable<Object> deleteBill(int id);
    #endregion
}