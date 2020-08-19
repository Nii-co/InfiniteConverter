using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InfiniteConverter
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainViewModel mainVM { get; set; }
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }
        public MainPage()
        {
            InitializeComponent();

            //EmployeeView.ItemsSource = employees;

            //// ObservableCollection allows items to be added after ItemsSource
            //// is set and the UI will react to changes
            //employees.Add(new Employee { DisplayName = "Rob Finnerty" });
            //employees.Add(new Employee { DisplayName = "Bill Wrestler" });
            //employees.Add(new Employee { DisplayName = "Dr. Geri-Beth Hooper" });
            //employees.Add(new Employee { DisplayName = "Dr. Keith Joyce-Purdy" });
            //employees.Add(new Employee { DisplayName = "Sheri Spruce" });
            //employees.Add(new Employee { DisplayName = "Burt Indybrick" });
            //employees.Add(new Employee { DisplayName = "Burt Indybrick" });
            //employees.Add(new Employee { DisplayName = "Burt Indybrick" });
            //employees.Add(new Employee { DisplayName = "Burt Indybrick" });
            //employees.Add(new Employee { DisplayName = "Burt Indybrick" });
            //employees.Add(new Employee { DisplayName = "Burt Indybrick" });
            //employees.Add(new Employee { DisplayName = "Burt Indybrick" });
            //employees.Add(new Employee { DisplayName = "Burt Indybrick" });
            //employees.Add(new Employee { DisplayName = "Burt Indybrick" });
            //employees.Add(new Employee { DisplayName = "Burt Indybrick" });
            //employees.Add(new Employee { DisplayName = "Burt Indybrick" });
            //employees.Add(new Employee { DisplayName = "Burt Indybrick" });
            mainVM = new MainViewModel();
            this.BindingContext = mainVM;

            myBtn.Clicked += MyBtn_Clicked;
        }

        private void MyBtn_Clicked(object sender, EventArgs e)
        {
            myEntry.Text = "aaa";
        }
    }
}
