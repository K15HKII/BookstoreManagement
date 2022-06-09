using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface IVoucherRepository
{
    #region Voucher

    [Get("/api/voucher/profiles")]
    IObservable<List<VoucherProfile>> getListVoucherProfile();
    
    [Get("/api/voucher/profile/{id}")]
    IObservable<VoucherProfile> getVoucherProfile(string id);
    
    [Get("/api/voucher/voucher/{voucher_id}")]
    IObservable<Voucher> getVoucher(string voucher_id);

    #endregion
}