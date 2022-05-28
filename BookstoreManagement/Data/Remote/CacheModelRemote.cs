using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;

namespace BookstoreManagement.Data.Remote
{
    public class CacheModelRemote : IModelRemote
    {

        private readonly IModelRemote _model;

        private List<Publisher>? _publishers = null;

        public CacheModelRemote(IModelRemote model)
        {
            _model = model;
        }

        public IObservable<List<User>> getListUser()
        {
            return _model.getListUser();
        }

        public IObservable<User> getUser(string id)
        {
            return _model.getUser(id);
        }

        public IObservable<object> saveUser(User user)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> deleteUser(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<Author>> getListAuthor()
        {
            throw new NotImplementedException();
        }

        public IObservable<Author> getAuthor(int id)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> saveAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> deleteAuthor(int id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<Publisher>> getListPublisher()
        {
            if (_publishers == null)
            {
                return _model
                    .getListPublisher()
                    .Do(result => _publishers = result);
            }
            return Observable.Empty(_publishers);
        }

        public IObservable<Publisher> getPublisher(int id)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> savePublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> deletePublisher(int id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<Transporter>> getListTransporter()
        {
            throw new NotImplementedException();
        }

        public IObservable<Transporter> getTransporter(int id)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> saveTransporter(Transporter transporter)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> deleteTransporter(int id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<Transport>> getListTransport()
        {
            throw new NotImplementedException();
        }

        public IObservable<Transport> getTransport(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> saveTransport(Transport transport)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> deleteTransport(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<BookProfile>> getListBookProfile()
        {
            throw new NotImplementedException();
        }

        public IObservable<BookProfile> getBookProfile(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> saveBookProfile(BookProfile bookProfile)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> deleteBookProfile(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<BookProfileImage>> getListBookProfileImage()
        {
            throw new NotImplementedException();
        }

        public IObservable<BookProfileImage> getBookProfileImage(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> saveBookProfileImage(BookProfileImage bookProfileImage)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> deleteBookProfileImage(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<Book>> getListBook()
        {
            throw new NotImplementedException();
        }

        public IObservable<Book> getBook(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> saveBook(Book book)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> deleteBook(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<Bill>> getListBill()
        {
            throw new NotImplementedException();
        }

        public IObservable<Bill> getBill(int id)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> saveBill(Bill bill)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> deleteBill(int id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<BillDetail>> getListBillDetail()
        {
            throw new NotImplementedException();
        }

        public IObservable<BillDetail> getBillDetail(int id)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> saveBillDetail(BillDetail billDetail)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> deleteBillDetail(int id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<CartItem>> getListCartItem()
        {
            throw new NotImplementedException();
        }

        public IObservable<CartItem> getCartItem(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> saveCartItem(CartItem cartItem)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> deleteCartItem(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<Lend>> getListLend()
        {
            throw new NotImplementedException();
        }

        public IObservable<Lend> getLend(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> saveLend(Lend lend)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> deleteLend(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<VoucherProfile>> getListVoucherProfile()
        {
            throw new NotImplementedException();
        }

        public IObservable<VoucherProfile> getVoucherProfile(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> saveVoucherProfile(Lend lend)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> deleteVoucherProfile(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<Voucher>> getListVoucher()
        {
            throw new NotImplementedException();
        }

        public IObservable<Voucher> getVoucher(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> saveVoucher(Lend lend)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> deleteVoucher(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<WildVoucher>> getListWildVoucher()
        {
            throw new NotImplementedException();
        }

        public IObservable<WildVoucher> getWildVoucher(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> saveWildVoucher(Lend lend)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> deleteWildVoucher(string id)
        {
            throw new NotImplementedException();
        }
    }
}
