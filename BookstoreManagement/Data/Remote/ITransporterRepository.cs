using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface ITransporterRepository
{
    #region Transporter
    [Get("/api/transporter")]
    IObservable<List<Transporter>> GetTransporters();

    [Get("/api/transporter")]
    IObservable<Transporter> GetTransporter(int id);

    [Post("/api/transporter")]
    IObservable<Object> SaveTransporter(Transporter transporter);

    [Delete("/api/transporter")]
    IObservable<Object> DeleteTransporter(int id);
    #endregion
}