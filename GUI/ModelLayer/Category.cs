using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace GUI.ModelLayer
{
    public class Category
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

        public int CategoryId { get; set; }
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

