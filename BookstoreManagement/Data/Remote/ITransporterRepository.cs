using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface ITransporterRepository
{
    #region Transporter
    [Get("/api/model/transporter")]
    IObservable<List<Transporter>> getListTransporter();

    [Get("/api/model/transporter")]
    IObservable<Transporter> getTransporter(int id);

    [Post("/api/model/transporter")]
    IObservable<Object> saveTransporter(Transporter transporter);

    [Delete("/api/model/transporter")]
    IObservable<Object> deleteTransporter(int id);
    #endregion
}