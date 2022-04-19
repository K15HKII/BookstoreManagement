using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace BookstoreManagement.Components
{

    public delegate IEnumerable<int> ReferencePageSelector(int currentPage, int maxPage);

    public delegate void PageChangedHandler(object sender, PageChangedEventArgs args);

    public class PageChangedEventArgs : RoutedEventArgs
    {
        public int OldPage { get; }

        public int NewPage { get; }

        public PageChangedEventArgs(RoutedEvent e, int oldPage, int newPage) : base(e)
        {
            OldPage = oldPage;
            NewPage = newPage;
        }
    }

    public class PageItemsNavigationBar : Control
    {

        #region Properties

        #region Selector
        public static readonly DependencyProperty SelectorProperty = DependencyProperty.Register(nameof(Selector),
            typeof(Selector),
            typeof(PageItemsNavigationBar),
            new FrameworkPropertyMetadata(null, OnSelectorChanged));

        public Selector Selector
        {
            get => (Selector)GetValue(SelectorProperty);
            set => SetValue(SelectorProperty, value);
        }

        private static void OnSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((PageItemsNavigationBar)d).OnSelectorChanged((Selector)e.OldValue, (Selector)e.NewValue);
        }

        private void OnSelectorChanged(Selector _old, Selector _new)
        {
            if (_old != null)
                _old.SelectionChanged -= OnSelectionChanged;

            if (_new != null)
            {
                _new.SelectionChanged += OnSelectionChanged;
                _new.SetBinding(ItemsControl.ItemsSourceProperty, _referenceNavigationBinding);
                RefreshPage();
            }
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count < 1)
                return;
                
            int NewPage = (int) (e.AddedItems[0] ?? SelectedPage);

            if (SelectedPage == NewPage)
                return;

            SelectedPage = NewPage;
        }
        #endregion

        #region ReferenceNavigation
        private static readonly DependencyPropertyKey ReferenceNavigationCollectionPropertyKey = DependencyProperty.RegisterReadOnly(
            nameof(ReferenceNavigationCollection),
            typeof(ObservableCollection<int>),
            typeof(PageItemsNavigationBar),
            new FrameworkPropertyMetadata(new ObservableCollection<int>()));

        public static readonly DependencyProperty ReferenceNavigationCollectionProperty = ReferenceNavigationCollectionPropertyKey.DependencyProperty;

        public ObservableCollection<int> ReferenceNavigationCollection
        {
            get => (ObservableCollection<int>)GetValue(ReferenceNavigationCollectionProperty);
            set => SetValue(ReferenceNavigationCollectionPropertyKey, value);
        }
        #endregion

        #region ReferencePageSelector
        private static IEnumerable<int> DefaultReferencePageSelector(int currentPage, int maxPage)
        {
            List<int> result = new List<int>();
            int maxLength = 5;

            int current = Math.Max(1, Math.Min(maxPage, currentPage));
            int need = maxLength - 1;

            int toLeft = need / 2;

            for (int i = currentPage - 1; i >= currentPage - toLeft && i > 0; i--)
            {
                result.Insert(0, i);
                need--;
            }

            result.Add(currentPage);

            int toRight = need;
            for (int i = currentPage + 1; i <= currentPage + toRight && i <= maxPage; i++)
            {
                result.Add(i);
                need--;
            }

            toLeft = need;
            int left = (result.Count > 0 ? result[0] : currentPage);
            for (int i = left - 1; i >= left - toLeft && i > 0; i--)
            {
                result.Insert(0, i);
                need--;
            }
            return result;
        }

        public static readonly DependencyProperty ReferencePageSelectorProperty = DependencyProperty.Register(
            nameof(ReferencePageSelector),
            typeof(ReferencePageSelector),
            typeof(PageItemsNavigationBar),
            new FrameworkPropertyMetadata((ReferencePageSelector)DefaultReferencePageSelector));

        public ReferencePageSelector ReferencePageSelector
        {
            get => (ReferencePageSelector)GetValue(ReferencePageSelectorProperty);
            set => SetValue(ReferencePageSelectorProperty, value);
        }
        #endregion

        #region PreviousButton
        public static readonly DependencyProperty PreviousButtonProperty = DependencyProperty.Register("PreviousButton",
            typeof(ButtonBase),
            typeof(PageItemsNavigationBar),
            new FrameworkPropertyMetadata(null, OnPreviousButtonChanged));

        public ButtonBase PreviousButton
        {
            get => (ButtonBase)GetValue(PreviousButtonProperty);
            set => SetValue(PreviousButtonProperty, value);
        }

        private static void OnPreviousButtonChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((PageItemsNavigationBar)d).OnPreviousButtonChanged((ButtonBase)e.OldValue, (ButtonBase)e.NewValue);
        }

        private void OnPreviousButtonChanged(ButtonBase _old, ButtonBase _new)
        {
            if (_old != null)
                _old.Click -= Previous;

            if (_new != null)
            {
                _new.Click += Previous;
            }
        }

        private void Previous(object sender, RoutedEventArgs args)
        {
            SelectedPage -= 1;
        }
        #endregion

        #region NextButton
        public static readonly DependencyProperty NextButtonProperty = DependencyProperty.Register("NextButton",
            typeof(ButtonBase),
            typeof(PageItemsNavigationBar),
            new FrameworkPropertyMetadata(null, OnNextButtonChanged));

        public ButtonBase NextButton
        {
            get => (ButtonBase)GetValue(NextButtonProperty);
            set => SetValue(NextButtonProperty, value);
        }
        private static void OnNextButtonChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((PageItemsNavigationBar)d).OnNextButtonChanged((ButtonBase)e.OldValue, (ButtonBase)e.NewValue);
        }

        private void OnNextButtonChanged(ButtonBase _old, ButtonBase _new)
        {
            if (_old != null)
                _old.Click -= Next;

            if (_new != null)
                _new.Click += Next;
        }

        private void Next(object sender, RoutedEventArgs args)
        {
            SelectedPage++;
        }
        #endregion

        #region HeadButton
        public static readonly DependencyProperty HeadButtonProperty = DependencyProperty.Register("HeadButton",
            typeof(ButtonBase),
            typeof(PageItemsNavigationBar),
            new FrameworkPropertyMetadata(null, OnHeadButtonChanged));

        public ButtonBase HeadButton
        {
            get => (ButtonBase)GetValue(HeadButtonProperty);
            set => SetValue(HeadButtonProperty, value);
        }

        private static void OnHeadButtonChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((PageItemsNavigationBar)d).OnHeadButtonChanged((ButtonBase)e.OldValue, (ButtonBase)e.NewValue);
        }

        private void OnHeadButtonChanged(ButtonBase _old, ButtonBase _new)
        {
            if (_old != null)
                _old.Click -= Head;

            if (_new != null)
                _new.Click += Head;
        }

        private void Head(object sender, RoutedEventArgs args)
        {
            SelectedPage = 1;
        }
        #endregion

        #region EndButton
        public static readonly DependencyProperty EndButtonProperty = DependencyProperty.Register("EndButton",
            typeof(ButtonBase),
            typeof(PageItemsNavigationBar),
            new FrameworkPropertyMetadata(null, OnEndButtonChanged));

        public ButtonBase EndButton
        {
            get => (ButtonBase)GetValue(EndButtonProperty);
            set => SetValue(EndButtonProperty, value);
        }

        private static void OnEndButtonChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((PageItemsNavigationBar)d).OnEndButtonChanged((ButtonBase)e.OldValue, (ButtonBase)e.NewValue);
        }

        private void OnEndButtonChanged(ButtonBase _old, ButtonBase _new)
        {
            if (_old != null)
                _old.Click -= End;

            if (_new != null)
                _new.Click += End;
        }

        private void End(object sender, RoutedEventArgs args)
        {
            SelectedPage = MaxPage;
        }
        #endregion

        #region SelectedPage
        public static readonly DependencyProperty SelectedPageProperty = DependencyProperty.Register(
            nameof(SelectedPage),
            typeof(int),
            typeof(PageItemsNavigationBar),
            new FrameworkPropertyMetadata(1, OnSelectedPageChanged, OnPrepareSelectedPageChange));

        private static object OnPrepareSelectedPageChange(DependencyObject d, object _new)
        {
            return ((PageItemsNavigationBar)d).OnPrepareSelectedPageChange((int)_new);
        }

        private static void OnSelectedPageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((PageItemsNavigationBar)d).OnSelectedPageChanged((int)e.OldValue, (int)e.NewValue);
        }

        public int SelectedPage
        {
            get => (int)GetValue(SelectedPageProperty);
            set => SetValue(SelectedPageProperty, value);
        }

        private int OnPrepareSelectedPageChange(int _new)
        {
            return Math.Max(1, Math.Min(MaxPage, _new));
        }

        private void OnSelectedPageChanged(int _old, int _new)
        {
            if (_old == _new)
                return;

            RaisePageChangedEvent(_old, _new);
            RefreshPage();
        }
        #endregion

        #region MaxPage
        public static readonly DependencyProperty MaxPageProperty = DependencyProperty.Register(
            nameof(MaxPage),
            typeof(int),
            typeof(PageItemsNavigationBar),
            new FrameworkPropertyMetadata(1, OnMaxPageChanged));

        public int MaxPage
        {
            get => (int)GetValue(MaxPageProperty);
            set => SetValue(MaxPageProperty, value);
        }

        private static void OnMaxPageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((PageItemsNavigationBar)d).OnMaxPageChanged((int)e.OldValue, (int)e.NewValue);
        }

        private void OnMaxPageChanged(int _old, int _new)
        {
            if (_old == _new)
                return;

            if (SelectedPage > _new)
                SelectedPage = _new;
            else
                RefreshPage();
        }
        #endregion

        #endregion

        #region Events

        #region PageChanged
        public static readonly RoutedEvent PageChangedEvent = EventManager.RegisterRoutedEvent(
            name: "PageChangedEvent",
            routingStrategy: RoutingStrategy.Bubble,
            handlerType: typeof(PageChangedHandler),
            ownerType: typeof(PageItemsNavigationBar));

        public event PageChangedHandler PageChanged
        {
            add => AddHandler(PageChangedEvent, value);
            remove => RemoveHandler(PageChangedEvent, value);
        }

        void RaisePageChangedEvent(int _old, int _new)
        {
            PageChangedEventArgs routedEventArgs = new PageChangedEventArgs(PageChangedEvent, _old, _new);
            RaiseEvent(routedEventArgs);
        }
        #endregion

        #endregion

        [NotNull] private Binding _referenceNavigationBinding = null!;

        private void RefreshPage()
        {
            ReferenceNavigationCollection.Clear();
            foreach (var i in ReferencePageSelector.Invoke(SelectedPage, MaxPage))
            {
                ReferenceNavigationCollection.Add(i);
            }

            if (Selector != null)
            {
                int index = ReferenceNavigationCollection.IndexOf(SelectedPage);
                if (Selector.SelectedIndex != index)
                    Selector.SelectedIndex = index;
            }
        }

        #region Constructors
        static PageItemsNavigationBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PageItemsNavigationBar),
                new FrameworkPropertyMetadata(typeof(PageItemsNavigationBar)));
        }

        public PageItemsNavigationBar() : base()
        {
            Initialize();
        }

        private void Initialize()
        {
            _referenceNavigationBinding = new Binding(nameof(ReferenceNavigationCollection))
            {
                Source = this
            };
        }
        #endregion

    }
}
