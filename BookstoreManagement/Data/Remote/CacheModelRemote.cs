using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model;
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

        public IObservable<List<User>> GetUsers()
        {
            return _model.GetUsers();
        }

        public IObservable<User> GetUser(string id)
        {
            return _model.GetUser(id);
        }

        public IObservable<object> SaveUser(User user)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> DeleteUser(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<UserAddress>> GetAddresses(string user_id)
        {
            throw new NotImplementedException();
        }

        public IObservable<UserAddress> GetAddress(string user_id, long address_id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<Author>> GetAuthors()
        {
            throw new NotImplementedException();
        }

        public IObservable<Author> GetAuthor(int id)
        {
            throw new NotImplementedException();
        }

        IObservable<Author> IAuthorRepository.CreateAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public IObservable<Author> UpdateAuthor(int id, Author author)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> CreateAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> DeleteAuthor(int id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<Publisher>> GetPublishers()
        {
            if (_publishers == null)
            {
                return _model
                    .GetPublishers()
                    .Do(result => _publishers = result);
            }
            return Observable.Empty(_publishers);
        }

        public IObservable<Publisher> GetPublisher(int id)
        {
            throw new NotImplementedException();
        }

        IObservable<Publisher> IPublisherRepository.CreatePublisher(PublisherUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public IObservable<Publisher> UpdatePublisher(int id, Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> CreatePublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> DeletePublisher(int id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<Transporter>> GetTransporters()
        {
            throw new NotImplementedException();
        }

        public IObservable<Transporter> GetTransporter(int id)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> SaveTransporter(Transporter transporter)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> DeleteTransporter(int id)
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

        public IObservable<object> deleteBookProfile(string id)
        {
            throw new NotImplementedException();
        }
        

        public IObservable<object> deleteBookProfileImage(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<Book>> GetBooks()
        {
            throw new NotImplementedException();
        }

        public IObservable<Book> GetBook(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<Book> CreateBook(BookUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public IObservable<Book> UpdateBook(string id, BookUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> DeleteBook(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<Bill>> GetBills()
        {
            throw new NotImplementedException();
        }

        public IObservable<Bill> GetBill(int id)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> SaveBill(Bill bill)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> UpdateBill(int billId, BillUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> DeleteBill(int id)
        {
            throw new NotImplementedException();
        }

        /*public IObservable<List<BillDetail>> getBillDetails(int billId)
        {
            throw new NotImplementedException();
        }*/

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

        public IObservable<List<Lend>> GetLends()
        {
            throw new NotImplementedException();
        }

        public IObservable<Lend> GetLend(string id)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> SaveLend(string id, Lend lend)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> saveLend(Lend lend)
        {
            throw new NotImplementedException();
        }

        public IObservable<object> DeleteLend(string id)
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

        public IObservable<List<User>> GetTopCustomers()
        {
            throw new NotImplementedException();
        }

        public IObservable<StatisticResult> GetBookRate(int book_id)
        {
            throw new NotImplementedException();
        }

        public IObservable<List<Feedback>> GetFeedbacks()
        {
            throw new NotImplementedException();
        }
    }
}
