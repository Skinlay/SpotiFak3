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
using System.Windows.Shapes;
using SpotiFak3.Classes;
using SQLite;


namespace SpotiFak3
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            //Connection to class
            Contact contact = new Contact()
            {
                Password = txtPassword.Text,
                Email = txtEmail.Text,
            };

            //Connection to database
            SQLiteConnection connection = new SQLiteConnection(App.strDatabasePath);
            {
                connection.CreateTable<Contact>();
                connection.Insert(contact);
            }

            //Close current window
            Close();
        }
    }
}
