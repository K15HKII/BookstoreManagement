using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface IAuthorRepository
{
    #region Author
    [Get("/api/author")]
    IObservable<List<Author>> GetAuthors();

    [Get("/api/author")]
    IObservable<Author> GetAuthor(int id);

    [Post("/api/author")]
    IObservable<Author> CreateAuthor([Body] Author author);
    
    [Put("/api/author/{id}")]
    IObservable<Author> UpdateAuthor(int id, [Body] Author author);

    [Delete("/api/author/{id}")]
    IObservable<Object> DeleteAuthor(int id);
    #endregion
}