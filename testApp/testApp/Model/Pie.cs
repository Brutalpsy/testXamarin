using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace testApp.Model
{
    public class Pie: INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private decimal? _price;


        public int Id { get => _id;
            set {
                _id = value;
                OnPropertyChanged("Id");

            }
        }
        public string Name {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public decimal? Price
        {
            get => _price;
            set
            {
                _price = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
