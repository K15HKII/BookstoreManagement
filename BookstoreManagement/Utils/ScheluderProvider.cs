using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace BookstoreManagement.Utils
{
    public class ScheluderProvider
    {

        private readonly Lazy<SynchronizationContext> _ui = new(() => new DispatcherSynchronizationContext(Application.Current.Dispatcher));

        public SynchronizationContext UI()
        {
            return _ui.Value;
        }

        public IScheduler IO()
        {
            return ThreadPoolScheduler.Instance;
        }

    }
}
