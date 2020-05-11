using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ModelLayer
{
    public class Product
    {
        private string name;
        public string Name {
            get { return name; }
            set {
                name = value;
                OnPropertyChanged();
                }
            }

        private decimal price;
        public decimal Price {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged();
            }
        }

        private string description;
        public string Description {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged();
            }
        }

        public int ProductId { get; set; }

        private int amountOnStock;
        public int AmountOnStock {
            get { return amountOnStock; }
            set
            {
                amountOnStock = value;
                OnPropertyChanged();
            }
        }

        private string brand;
        public string Brand {
            get { return brand; }
            set
            {
                brand = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(
            [CallerMemberName] string caller = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
        public override string ToString()
        {
            return $"{Name} - {Price} - {ProductId} - {Brand}";
        }

    }
}

