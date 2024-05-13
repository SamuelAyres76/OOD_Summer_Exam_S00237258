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

namespace Restaurant_App
{
    public partial class CustomerSearchResults : Window
    {
        public CustomerSearchResults()
        {
            InitializeComponent();
        }

        // Update List with entries with similar names
        private void MatchingCustomers_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        // Create the booking by taking in the data from the textboxes
        private void CreateBooking_Click(object sender, RoutedEventArgs e)
        {
            // Get the customer name and contact number from the textboxes
            // string customerName = CustomerNameTextBox.Text;
            // string contactNumber = ContactNumberTextBox.Text;
        }

    }
}
