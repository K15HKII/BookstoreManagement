using System;
using System.Collections.Generic;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote;

public interface ICartItemRepository
{
    #region CartItem
    [Get("/api/model/cart")]
    IObservable<List<CartItem>> getListCartItem();

    [Get("/api/model/cart")]
    IObservable<CartItem> getCartItem(string id);

    [Post("/api/model/cart")]
    IObservable<Object> saveCartItem(CartItem cartItem);

    [Delete("/api/model/cart")]
    IObservable<Object> deleteCartItem(string id);
    #endregion
}