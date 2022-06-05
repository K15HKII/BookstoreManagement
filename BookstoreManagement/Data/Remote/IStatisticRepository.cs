using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface IStatisticRepository
{
    
    [Get("/api/statistic/user/top")]
    IObservable<List<User>> GetTopCustomers();
    
}