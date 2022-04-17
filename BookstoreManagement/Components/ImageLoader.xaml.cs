using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookstoreManagement.Components
{
    /// <summary>
    /// Interaction logic for ImageLoader.xaml
    /// </summary>
    public partial class ImageLoader : UserControl
    {
        private static List<ImageLoader> avatarInstance = new List<ImageLoader>();

        public ImageLoader()
        {
            InitializeComponent();
        }

        public string UserID
        {
            get { return (string)GetValue(UserIDProperty); }
            set { SetValue(UserIDProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UserID.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserIDProperty =
            DependencyProperty.Register(nameof(UserID), typeof(string), typeof(ImageLoader), new FrameworkPropertyMetadata(null));

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            if (e.Property == UserIDProperty)
            {
                Update();
            }
            base.OnPropertyChanged(e);
        }

        private void Update()
        {
            LoadingMask.Visibility = Visibility.Visible;
        }

        public static void UpdateAllInstance(String userID = null)
        {
            foreach (var avatarDisplayer in avatarInstance)//.Where(target => string.CompareOrdinal(target.UserID, userID) == 0))
            {
                avatarDisplayer.Update();
            }
        }

        private void OnUnload(object sender, RoutedEventArgs e)
        {
            avatarInstance.Remove(this);
        }

        #region Custom ClickEvent
        public event EventHandler Click;

        private void BtnClick(object sender, RoutedEventArgs e)
        {
            if (Click != null)
                Click(this, e);
        }
        #endregion

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            ImageLoader demo = avatarInstance.Where(p => p.UserID == this.UserID).FirstOrDefault();
            if (demo != null)
            {
                this.ImageAva.ImageSource = demo.ImageAva.ImageSource;
                this.LoadingMask.Visibility = Visibility.Hidden;
            }
            else
            {
                //
            }
            if (!avatarInstance.Contains(this))
                avatarInstance.Add(this);
        }
    }
}
