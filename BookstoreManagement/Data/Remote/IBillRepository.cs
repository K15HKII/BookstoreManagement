﻿using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface IBillRepository
{
    #region Bill
    [Get("/api/bill/search")]
    IObservable<List<Bill>> GetBills();

    [Get("/api/bill/{id}")]
    IObservable<Bill> GetBill([AliasAs("id")] int id);

    [Post("/api/bill")]
    IObservable<Object> SaveBill(Bill bill);

    [Delete("/api/bill")]
    IObservable<Object> DeleteBill(int id);
    #endregion
}