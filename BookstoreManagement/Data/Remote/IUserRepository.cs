using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface IUserRepository
{
    #region User 
    [Get("/api/user")]
    IObservable<List<User>> getListUser();

    [Get("/api/user")]
    IObservable<User> getUser(string id);

    [Post("/api/user")]
    IObservable<Object> saveUser(User user);

    [Delete("/api/user")]
    IObservable<Object> deleteUser(string id);
    #endregion
}