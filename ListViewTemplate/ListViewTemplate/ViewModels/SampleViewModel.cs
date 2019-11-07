using ListViewTemplate.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListViewTemplate.ViewModels
{
    public class SampleViewModel : INotifyPropertyChanged
    {
        public SampleViewModel()
        {
            SampleItems = new ObservableCollection<Models.SampleItem>();
        }

        private ObservableCollection<SampleItem> _SampleItems;

        public ObservableCollection<SampleItem> SampleItems
        {
            get
            {
                return _SampleItems;
            }
            set
            {
                if (_SampleItems != value)
                {
                    _SampleItems = value;
                }

                OnPropertyChanged(nameof(SampleItems));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}