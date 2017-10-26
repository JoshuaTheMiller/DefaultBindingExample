using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace BusyViewExampleFromQuestion
{
    public class BusyView : ContentControl
    {
        static BusyView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BusyView), new FrameworkPropertyMetadata(typeof(BusyView)));
        }

        public BusyView()
        {
            SetBinding(IsBusyProperty, new Binding("Busy"));
        }

        public static readonly DependencyProperty IsBusyProperty =
            DependencyProperty.Register("IsBusy", typeof(bool), typeof(BusyView), new PropertyMetadata(false));

        public bool IsBusy
        {
            get { return (bool)GetValue(IsBusyProperty); }
            set { SetValue(IsBusyProperty, value); }
        }
    }
}
