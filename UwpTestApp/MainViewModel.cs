using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UwpTestApp
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private String _sparePart1MacAddress;
        private String _sparePart2MacAddress;

        public event PropertyChangedEventHandler PropertyChanged;

        public String SparePart1MacAddress
        {
            get
            {
                return _sparePart1MacAddress;
            }
            set
            {
                _sparePart1MacAddress = value;
                OnPropertyChanged(nameof(SparePart1MacAddress));
            }
        }

        public String SparePart2MacAddress
        {
            get
            {
                return _sparePart2MacAddress;
            }
            set
            {
                _sparePart2MacAddress = value;
                OnPropertyChanged(nameof(SparePart2MacAddress));
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public MainViewModel()
        {
        }


    }
}
