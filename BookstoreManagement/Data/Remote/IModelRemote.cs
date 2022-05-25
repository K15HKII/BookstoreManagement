using BookstoreManagement.Data.Model.Api;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Data.Remote
{
    public interface IModelRemote
    {
        #region User 
        [Get("api/model/user")]
        IObservable<List<User>> getListUser();

        [Get("api/model/user")]
        IObservable<User> getUser(string id);

        [Post("api/model/user")]
        IObservable<Object> saveUser(User user);

        [Delete("api/model/user")]
        IObservable<Object> deleteUser(string id);
        #endregion

        #region Author
        [Get("api/model/author")]
        IObservable<List<Author>> getListAuthor();

        [Get("api/model/author")]
        IObservable<Author> getAuthor(int id);

        [Post("api/model/author")]
        IObservable<Object> saveAuthor(Author author);

        [Delete("api/model/author")]
        IObservable<Object> deleteAuthor(int id);
        #endregion

        #region Publisher
        [Get("api/model/publisher")]
        IObservable<List<Publisher>> getListPublisher();

        [Get("api/model/publisher")]
        IObservable<Publisher> getPublisher(int id);

        [Post("api/model/publisher")]
        IObservable<Object> savePublisher(Publisher publisher);

        [Delete("api/model/publisher")]
        IObservable<Object> deletePublisher(int id);
        #endregion

        #region Transporter
        [Get("api/model/transporter")]
        IObservable<List<Transporter>> getListTransporter();

        [Get("api/model/transporter")]
        IObservable<Transporter> getTransporter(int id);

        [Post("api/model/transporter")]
        IObservable<Object> saveTransporter(Transporter transporter);

        [Delete("api/model/transporter")]
        IObservable<Object> deleteTransporter(int id);
        #endregion

        #region Transport
        [Get("api/model/transport")]
        IObservable<List<Transport>> getListTransport();

        [Get("api/model/transport")]
        IObservable<Transport> getTransport(string id);

        [Post("api/model/transport")]
        IObservable<Object> saveTransport(Transport transport);

        [Delete("api/model/transport")]
        IObservable<Object> deleteTransport(string id);
        #endregion

        #region BookProfile
        [Get("api/model/bookprofile")]
        IObservable<List<BookProfile>> getListBookProfile();

        [Get("api/model/bookprofile")]
        IObservable<BookProfile> getBookProfile(string id);

        [Post("api/model/bookprofile")]
        IObservable<Object> saveBookProfile(BookProfile bookProfile);

        [Delete("api/model/bookprofile")]
        IObservable<Object> deleteBookProfile(string id);
        #endregion

        #region BookProfileImage
        [Get("api/model/bookprofileimage")]
        IObservable<List<BookProfileImage>> getListBookProfileImage();

        [Get("api/model/bookprofileimage")]
        IObservable<BookProfileImage> getBookProfileImage(string id);

        [Post("api/model/bookprofileimage")]
        IObservable<Object> saveBookProfileImage(BookProfileImage bookProfileImage);

        [Delete("api/model/bookprofileimage")]
        IObservable<Object> deleteBookProfileImage(string id);
        #endregion

        #region Book
        [Get("api/model/book")]
        IObservable<List<Book>> getListBook();

        [Get("api/model/book")]
        IObservable<Book> getBook(string id);

        [Post("api/model/book")]
        IObservable<Object> saveBook(Book book);

        [Delete("api/model/book")]
        IObservable<Object> deleteBook(string id);
        #endregion

        #region Bill
        [Get("api/model/bill")]
        IObservable<List<Bill>> getListBill();

        [Get("api/model/bill")]
        IObservable<Bill> getBill(int id);

        [Post("api/model/bill")]
        IObservable<Object> saveBill(Bill bill);

        [Delete("api/model/bill")]
        IObservable<Object> deleteBill(int id);
        #endregion

        #region BillDetail
        [Get("api/model/billdetail")]
        IObservable<List<BillDetail>> getListBillDetail();

        [Get("api/model/billdetail")]
        IObservable<BillDetail> getBillDetail(int id);

        [Post("api/model/billdetail")]
        IObservable<Object> saveBillDetail(BillDetail billDetail);

        [Delete("api/model/billdetail")]
        IObservable<Object> deleteBillDetail(int id);
        #endregion

        #region CartItem
        [Get("api/model/cart")]
        IObservable<List<CartItem>> getListCartItem();

        [Get("api/model/cart")]
        IObservable<CartItem> getCartItem(string id);

        [Post("api/model/cart")]
        IObservable<Object> saveCartItem(CartItem cartItem);

        [Delete("api/model/cart")]
        IObservable<Object> deleteCartItem(string id);
        #endregion

        #region Lend
        [Get("api/model/lend")]
        IObservable<List<Lend>> getListLend();

        [Get("api/model/lend")]
        IObservable<Lend> getLend(string id);

        [Post("api/model/lend")]
        IObservable<Object> saveLend(Lend lend);

        [Delete("api/model/lend")]
        IObservable<Object> deleteLend(string id);
        #endregion

        #region VoucherProfile
        [Get("api/model/voucherprofile")]
        IObservable<List<VoucherProfile>> getListVoucherProfile();

        [Get("api/model/voucherprofile")]
        IObservable<VoucherProfile> getVoucherProfile(string id);

        [Post("api/model/voucherprofile")]
        IObservable<Object> saveVoucherProfile(Lend lend);

        [Delete("api/model/voucherprofile")]
        IObservable<Object> deleteVoucherProfile(string id);
        #endregion

        #region Voucher
        [Get("api/model/voucher")]
        IObservable<List<Voucher>> getListVoucher();

        [Get("api/model/voucher")]
        IObservable<Voucher> getVoucher(string id);

        [Post("api/model/voucher")]
        IObservable<Object> saveVoucher(Lend lend);

        [Delete("api/model/voucher")]
        IObservable<Object> deleteVoucher(string id);
        #endregion

        #region WildVoucher
        [Get("api/model/wildvoucher")]
        IObservable<List<WildVoucher>> getListWildVoucher();

        [Get("api/model/wildvoucher")]
        IObservable<WildVoucher> getWildVoucher(string id);

        [Post("api/model/wildvoucher")]
        IObservable<Object> saveWildVoucher(Lend lend);

        [Delete("api/model/wildvoucher")]
        IObservable<Object> deleteWildVoucher(string id);
        #endregion
    }
}
