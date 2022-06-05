using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface ITransporterRepository
{
    #region Transporter
    [Get("/api/transporter")]
    IObservable<List<Transporter>> getListTransporter();

    [Get("/api/transporter")]
    IObservable<Transporter> getTransporter(int id);

    [Post("/api/transporter")]
    IObservable<Object> saveTransporter(Transporter transporter);

    [Delete("/api/transporter")]
    IObservable<Object> deleteTransporter(int id);
    #endregion
}