using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Api;
using Refit;

namespace BookstoreManagement.Data.Remote
{
    public interface IFeedbackRepository
    {

        [Get("/api/message/feedbacks")]
        IObservable<List<Feedback>> GetFeedbacks();

    }
}
