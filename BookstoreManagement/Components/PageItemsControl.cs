using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:BookstoreManagement.Components"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:BookstoreManagement.Components;assembly=BookstoreManagement.Components"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:PageItemsControl/>
    ///
    /// </summary>
    public class PageItemsControl : ItemsControl
    {
        //TODO: Bug chuyển trang qua rồi quay lại thì mất chuyển trang

        #region Constructors
        static PageItemsControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PageItemsControl),
                new FrameworkPropertyMetadata(typeof(PageItemsControl)));
        }

        public PageItemsControl() : base()
        {
            Initialize();
        }

        private void Initialize()
        {
            _referenceCollectionBinding = new Binding(nameof(ReferenceCollection))
            {
                Source = this
            };
            ReferenceCollection = new ObservableCollection<object>();
        }

        protected override void OnItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue)
        {
            base.OnItemsSourceChanged(oldValue, newValue);
            RefreshMaxPage();
            UpdateReferenceItems();
        }

        #endregion

        #region Properties
        #region ItemsTemplate
        public static readonly DependencyProperty ItemsTemplateProperty = DependencyProperty.Register(nameof(ItemsTemplate),
            typeof(ItemsControl),
            typeof(PageItemsControl),
            new FrameworkPropertyMetadata(null, OnItemsTemplateChanged));

        public ItemsControl ItemsTemplate
        {
            get => (ItemsControl)GetValue(ItemsTemplateProperty);
            set => SetValue(ItemsTemplateProperty, value);
        }

        private static void OnItemsTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((PageItemsControl)d).OnItemsTemplateChanged((ItemsControl)e.OldValue, (ItemsControl)e.NewValue);
        }

        public void OnItemsTemplateChanged(ItemsControl _old, ItemsControl _new)
        {
            _new.SetBinding(ItemsControl.ItemsSourceProperty, _referenceCollectionBinding);
        }
        #endregion

        #region Bar
        public static readonly DependencyProperty NavigationBarProperty = DependencyProperty.Register(nameof(NavigationBar),
            typeof(PageItemsNavigationBar),
            typeof(PageItemsControl),
            new FrameworkPropertyMetadata(null, OnNavigationBarChanged));

        public PageItemsNavigationBar NavigationBar
        {
            get => (PageItemsNavigationBar)GetValue(NavigationBarProperty);
            set => SetValue(NavigationBarProperty, value);
        }

        private static void OnNavigationBarChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((PageItemsControl)d).OnNavigationBarChanged((PageItemsNavigationBar)e.OldValue, (PageItemsNavigationBar)e.NewValue);
        }

        private void OnNavigationBarChanged(PageItemsNavigationBar _old, PageItemsNavigationBar _new)
        {
            if (_old != null)
                _old.PageChanged -= OnPageChanged;

            if (_new != null)
            {
                _new.PageChanged += OnPageChanged;
                CurrentPage = _new.SelectedPage;
            }
        }
        #endregion

        #region ItemsPerPage
        public static readonly DependencyProperty ItemsPerPageProperty = DependencyProperty.Register(nameof(ItemsPerPage),
            typeof(int),
            typeof(PageItemsControl),
            new FrameworkPropertyMetadata(3, OnItemsPerPageChanged));

        public int ItemsPerPage
        {
            get => (int)GetValue(ItemsPerPageProperty);
            set => SetValue(ItemsPerPageProperty, value);
        }

        private static void OnItemsPerPageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((PageItemsControl)d).OnItemsPerPageChanged((int)e.OldValue, (int)e.NewValue);
        }

        private void OnItemsPerPageChanged(int _old, int _new)
        {
            int maxPage = MaxPagePossible();
            if (MaxPage != maxPage)
                MaxPage = maxPage;
        }
        #endregion

        #region SelectedPage
        private static readonly DependencyPropertyKey CurrentPagePropertyKey = DependencyProperty.RegisterReadOnly(
            nameof(CurrentPage),
            typeof(int),
            typeof(PageItemsControl),
            new FrameworkPropertyMetadata(0, OnCurrentPageChanged));

        private static void OnCurrentPageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((PageItemsControl) d).OnCurrentPageChanged((int) e.OldValue, (int) e.NewValue);
        }

        private void OnCurrentPageChanged(int eOldValue, int eNewValue)
        {
            UpdateReferenceItems();
        }

        public static readonly DependencyProperty CurrentPageProperty = CurrentPagePropertyKey.DependencyProperty;

        public int CurrentPage
        {
            get => (int)GetValue(CurrentPageProperty);
            set => SetValue(CurrentPagePropertyKey, value);
        }
        #endregion

        #region MaxPage
        private static readonly DependencyPropertyKey MaxPagePropertyKey = DependencyProperty.RegisterReadOnly(
           nameof(MaxPage),
           typeof(int),
           typeof(PageItemsControl),
           new FrameworkPropertyMetadata(0, OnMaxPageChanged));

        private static void OnMaxPageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((PageItemsControl) d).OnMaxPageChanged((int) e.OldValue, (int) e.NewValue);
        }

        private void OnMaxPageChanged(int _old, int _new)
        {
            if (_old != _new && CurrentPage > _new)
            {
                NavigationBar.SelectedPage = _new;
            }
        }

        public static readonly DependencyProperty MaxPageProperty = MaxPagePropertyKey.DependencyProperty;

        public int MaxPage
        {
            get => (int)GetValue(MaxPageProperty);
            set => SetValue(MaxPagePropertyKey, value);
        }
        #endregion

        #region ReferenceCollection
        private static readonly DependencyPropertyKey ReferenceCollectionPropertyKey = DependencyProperty.RegisterReadOnly(
            nameof(ReferenceCollection),
            typeof(ObservableCollection<object>),
            typeof(PageItemsControl),
            new FrameworkPropertyMetadata(new ObservableCollection<object>()));

        public static readonly DependencyProperty ReferenceCollectionProperty = ReferenceCollectionPropertyKey.DependencyProperty;

        public ObservableCollection<object> ReferenceCollection { get => (ObservableCollection<object>)GetValue(ReferenceCollectionProperty); set => SetValue(ReferenceCollectionPropertyKey, value); }
        #endregion 
        #endregion

        [NotNull] private Binding _referenceCollectionBinding = null!;

        private void OnPageChanged(object sender, PageChangedEventArgs e)
        {
            CurrentPage = e.NewPage;
        }

        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e)
        {
            base.OnItemsChanged(e);
            RefreshMaxPage();
        }

        private void RefreshMaxPage()
        {
            int MaxPage = MaxPagePossible();
            if (this.MaxPage != MaxPage)
            {
                this.MaxPage = MaxPage;
            }
        }

        private int MaxPagePossible()
        {
            return Math.Max(Items.Count / ItemsPerPage + (Items.Count % ItemsPerPage > 0 ? 1 : 0), 1);
        }

        private void UpdateReferenceItems()
        {
            int from = Math.Max(0, (CurrentPage - 1) * ItemsPerPage);
            int to = Math.Min(Items.Count, CurrentPage * ItemsPerPage);

            ReferenceCollection.Clear();
            for (int i = from; i < to; i++)
            {
                ReferenceCollection.Add(Items.GetItemAt(i));
            }
        }

    }

}