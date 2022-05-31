using BookstoreManagement.Data.Model.Api;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Data.Remote
{
    public interface IModelRemote : IAuthorRepository, IPublisherRepository, IBookRepository, ITransporterRepository, ITransportRepository, IUserRepository, ICartItemRepository, IBillRepository
    {
    }
}
