using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace CA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //a collection of the names of employees
        ObservableCollection<Employee> names = new ObservableCollection<Employee>();

        //a collection of the part time and full time employees
        ObservableCollection<Employee> Part = new ObservableCollection<Employee>();
        ObservableCollection<Employee> Full = new ObservableCollection<Employee>();


        public MainWindow()
        {
            InitializeComponent();
        }



        private void LBXnames_Loaded(object sender, RoutedEventArgs e)
        {

            //displays the data in the observable collection of names
            LBXnames.ItemsSource = names;


        }

        private void TBXfirstname_GotFocus(object sender, RoutedEventArgs e)
        {
            //when you click on The text box for the firstname it clears any text that was there previously
            TBXfirstname.Clear();
        }
        private void TBXsurename_GotFocus(object sender, RoutedEventArgs e)
        {
            //when you click on The text box for the surename it clears any text that was there previously
            TBXsurename.Clear();
        }

        private void BTNadd_Click(object sender, RoutedEventArgs e)
        {


            //firstname
            string firstName = TBXfirstname.Text;
            //last name
            string sureName = TBXsurename.Text;

            Employee employee;

            //if full time then creates a full time employee
            if (BTNfulltime.IsChecked == true)
            {

                employee = new Employee(firstName, sureName, "Full time");
                Full.Add(employee);
                //calcutlates the salary
                TBXsalary.Text = Convert.ToString(Convert.ToDouble(TBXhoursworked.Text) * Convert.ToDouble(TBXhourlyrate.Text) * 12);

            }
            //if part time then create a part time employee
            else
            {
                //check which radio button is check - part time or full time
                employee = new Employee(firstName, sureName, "Part time");
                Part.Add(employee);
                //calculates the monthly pay
                if (TBXhourlyrate.Text.Length > 0 && TBXhoursworked.Text.Length > 0)
                {
                    TBXmonthlypay.Text = Convert.ToString(Convert.ToDouble(TBXhoursworked.Text) * Convert.ToDouble(TBXhourlyrate.Text));
                }
            }
            names.Add(employee);
        }
        private void BTNclear_Click(object sender, RoutedEventArgs e)
        {
            //clears the boxes that the user inputs their info into
            TBXfirstname.Clear();
            TBXsurename.Clear();
            TBXhoursworked.Clear();
            TBXhourlyrate.Clear();
            TBXmonthlypay.Clear();
            TBXsalary.Clear();
        }
        private void CHCKBXparttime_Checked(object sender, RoutedEventArgs e)
        {
            //filters the listbox by the part time employees,it displays only the part time
            if (CHCKBXparttime.IsChecked == true)
            {
                LBXnames.ItemsSource = Part;
            }

        }

        private void CHCKBXfulltime_Checked(object sender, RoutedEventArgs e)
        {
            //filters the listbox by the full time employees,it displays only the full time
            if (CHCKBXfulltime.IsChecked == true)
            {
                LBXnames.ItemsSource = Full;
            }

        }


        private void TBXhoursworked_GotFocus(object sender, RoutedEventArgs e)
        {



        }

        private void TBXhourlyrate_GotFocus(object sender, RoutedEventArgs e)
        {



        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }


    }
       

       

       
}
    

