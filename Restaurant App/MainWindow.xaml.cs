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

namespace Restaurant_App
{
    public partial class MainWindow : Window
    {
        private CustomerClass db;

        public MainWindow()
        {
            InitializeComponent();
            db = new CustomerClass();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            try
            {
                var Bookings = db.Bookings.ToList();
                listBoxMovies.ItemsSource = Bookings;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Displaying Restauarant Bookings: " + ex.Message);
            }
        }
    }
}
