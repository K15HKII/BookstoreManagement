using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface IBookRepository
{
    #region Book
    [Get("/api/model/book")]
    IObservable<List<Book>> getListBook();

    [Get("/api/model/book")]
    IObservable<Book> getBook(string id);

    [Post("/api/model/book")]
    IObservable<Object> saveBook(Book book);

    [Delete("/api/model/book")]
    IObservable<Object> deleteBook(string id);
    #endregion
}