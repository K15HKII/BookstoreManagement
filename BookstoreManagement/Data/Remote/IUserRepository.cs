﻿using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface IUserRepository
{
    #region User 
    [Get("/api/user")]
    IObservable<List<User>> GetUsers();

    [Get("/api/user/{id}")]
    IObservable<User> GetUser([AliasAs("id")] string id);

    [Post("/api/user")]
    IObservable<Object> SaveUser(User user);

    [Delete("/api/user")]
    IObservable<Object> DeleteUser(string id);
    
    //TODO: Lấy địa chỉ người dùng và bank
    #endregion
}