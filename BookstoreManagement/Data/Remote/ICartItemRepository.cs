using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface ICartItemRepository
{
    #region CartItem
    [Get("/api/cart")]
    IObservable<List<CartItem>> getListCartItem();

    [Get("/api/cart")]
    IObservable<CartItem> getCartItem(string id);

    [Post("/api/cart")]
    IObservable<Object> saveCartItem(CartItem cartItem);

    [Delete("/api/cart")]
    IObservable<Object> deleteCartItem(string id);
    #endregion
}