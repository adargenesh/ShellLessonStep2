using ShellLessonStep2.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShellLessonStep2.Services;

namespace ShellLessonStep2.ViewModels
{
    internal class BearsViewModel : ViewModelBase   
    {
        private ObservableCollection<Bears> bears;
        public ObservableCollection<Bears> Bears
        {
            get
            {
                return this.bears;
            }
            set
            {
                this.bears = value;
                OnPropertyChanged();


            }
        }


        private AnimalService BearsService;
        public BearsViewModel(AnimalService service)
        {
            this.studentsService = service;
            students = new ObservableCollection<Student>();
            ReadStudents();
        }

        private async void ReadStudents()
        {
            StudentsService service = this.studentsService;
            List<Student> list = await service.GetStudents();
            this.Students = new ObservableCollection<Student>(list);
        }


    }
}
