using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BusyViewExampleFromQuestion
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private bool busy = false;
        public bool Busy
        {
            get => busy;
            set => SetField(ref busy, value);
        }

        private bool explicitBusy = false;
        public bool ExplicitBusy
        {
            get => explicitBusy;
            set => SetField(ref explicitBusy, value);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            field = value;
            NotifyPropertyChanged(propertyName);
        }

        private void NotifyPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
