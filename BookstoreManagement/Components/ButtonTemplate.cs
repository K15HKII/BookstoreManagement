using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BookstoreManagement.Components
{
    public class ButtonTemplate : DataTemplate
    {

        public ButtonTemplate()
        {
            FrameworkElementFactory factory = new FrameworkElementFactory(typeof(Button));
            VisualTree = factory;
        }

    }
}
