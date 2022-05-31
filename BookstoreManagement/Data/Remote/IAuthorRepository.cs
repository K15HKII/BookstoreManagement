using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface IAuthorRepository
{
    #region Author
    [Get("/api/model/author")]
    IObservable<List<Author>> getListAuthor();

    [Get("/api/model/author")]
    IObservable<Author> getAuthor(int id);

    [Post("/api/model/author")]
    IObservable<Object> saveAuthor(Author author);

    [Delete("/api/model/author")]
    IObservable<Object> deleteAuthor(int id);
    #endregion
}