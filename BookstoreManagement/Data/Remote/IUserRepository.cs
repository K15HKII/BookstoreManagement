using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface IUserRepository
{
    #region User 
    [Get("/api/model/user")]
    IObservable<List<User>> getListUser();

    [Get("/api/model/user")]
    IObservable<User> getUser(string id);

    [Post("/api/model/user")]
    IObservable<Object> saveUser(User user);

    [Delete("/api/model/user")]
    IObservable<Object> deleteUser(string id);
    #endregion
}