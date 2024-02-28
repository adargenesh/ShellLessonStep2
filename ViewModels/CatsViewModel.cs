using ShellLessonStep2.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellLessonStep2.ViewModels
{
    internal class CatsViewModel : ViewModelBase
    {
        private ObservableCollection<Cats> cats;
        public ObservableCollection<Cats> Cats
        {
            get
            {
                return this.cats;
            }
            set
            {
                this.cats = value;
                OnPropertyChanged();
            }
        }

    }
}
