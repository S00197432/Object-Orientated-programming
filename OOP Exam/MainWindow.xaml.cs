using System;
using System.Collections.Generic;
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

namespace OOP_Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Account> AccountList;
        public List<Account> SavingsAccountList;
        public List<Account> CurrentAccountList;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CHKBXcurrentAccount.IsChecked = true;
            CHKBXsavingsAccount.IsChecked = true;

            LBXAccountList.ItemsSource = AccountList;

            AccountList = new List<Account>();
            SavingsAccountList = new List<Account>();
            CurrentAccountList = new List<Account>();
            
            SavingsAccount SA1 = new SavingsAccount() { FirstName = "Adam", LastName = "Hoffman", Balance = 1000, AccountType = "savingsAccount", InterestDate = "11/01/2021" };
            CurrentAccount CA1 = new CurrentAccount() { FirstName = "Iron", LastName = "Man", Balance = 100000000, AccountType = "Current Account", InterestDate = "11/01/2021" };

            AccountList.Add(SA1);
            AccountList.Add(CA1);

            SavingsAccountList.Add(SA1);       
            CurrentAccountList.Add(CA1);

            Account account;
        }

        private void CHKBXsavingsAccount_Checked(object sender, RoutedEventArgs e)
        {
            if (CHKBXcurrentAccount.IsChecked == false && CHKBXsavingsAccount.IsChecked == true)
            {
                LBXAccountList.ItemsSource = SavingsAccountList;

            }
        }

        private void CHKBXcurrentAccount_Checked(object sender, RoutedEventArgs e)
        {
            if (CHKBXcurrentAccount.IsChecked == true && CHKBXsavingsAccount.IsChecked == false)
            {
                LBXAccountList.ItemsSource = CurrentAccountList;
            }
        }

        private void BTNDeposit_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
