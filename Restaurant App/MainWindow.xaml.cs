using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Restaurant_App
{
    public partial class MainWindow : Window
    {
        // Call the Database
        private CustomerClass db;
        // Restaurant capacity
        private int restaurantCapacity = 40;

        public MainWindow()
        {
            InitializeComponent();
            db = new CustomerClass();
            LoadCustomers();
        }

        // Load customer data (bookings for the selected date)
        private void LoadCustomers()
        {
            try
            {
                // Getting the selected date from DatePicker
                DateTime selectedDate = DatePicker.SelectedDate ?? DateTime.Today;

                // Filter the bookings for the selected date
                var bookings = db.Bookings
                    .Where(b => b.BookingsDate.Date == selectedDate.Date)
                    .ToList();

                // Updating the list box
                listBoxBookings.ItemsSource = bookings;

                // Update available space
                int totalParticipants = bookings.Sum(b => b.NumberOfParticipants);
                int availableSpace = restaurantCapacity - totalParticipants;
                // textBlockAvailableSpace.Text = $"Available Space: {availableSpace} out of {restaurantCapacity}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying bookings: " + ex.Message);
            }
        }

        // Handle the selection changed for booking details.
        private void ListBoxBookings_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // Handling any date change event
        private void DateChanged(object sender, SelectionChangedEventArgs e)
        {
            // Reload bookings when the date changes
            LoadCustomers();
        }

        // Book Seats Button
        private void ButtonBookSeats_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CustomerSearch_Click(object sender, RoutedEventArgs e)
        {
            // Go to the other page.
        }
    }
}
