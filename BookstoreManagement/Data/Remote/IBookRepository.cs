using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface IBookRepository
{
    #region Book
    [Get("/api/book/search")]
    IObservable<List<Book>> GetBooks();

    [Get("/api/book/info/{id}")]
    IObservable<Book> GetBook(string id);

    [Post("/api/book")]
    IObservable<Book> CreateBook(BookUpdateRequest request);

    [Post("/api/book/{id}")]
    IObservable<Book> UpdateBook(string id, BookUpdateRequest request);

    [Delete("/api/book/{id}")]
    IObservable<Object> DeleteBook(string id);
    #endregion
}