using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using SQLview.Model;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace SQLview.ViewModels
{
    public class SqlViewModel : INotifyPropertyChanged
    {
        private Sqles _newSqles;
        public ObservableCollection<Sqles> ListOfSql { get; set; }
        public ICommand AddNameCommand { get; set; }

        public SqlViewModel()
        {
            ListOfSql = new ObservableCollection<Sqles> { new Sqles("Prvni", "SELECT * FROM AAA"), new Sqles("Druhy", "SELECT * FROM BBB") };
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

}



