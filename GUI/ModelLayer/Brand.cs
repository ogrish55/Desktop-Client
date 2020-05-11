using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ModelLayer
{
    public class Brand
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public int BrandId { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(
            [CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }


}
