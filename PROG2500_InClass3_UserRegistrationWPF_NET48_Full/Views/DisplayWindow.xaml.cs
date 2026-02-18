using System;
using System.Windows;

namespace UserRegistrationWPF.Views
{
    /// <summary>
    /// Display window that shows the submitted registration data.
    /// Displays all registration information with the password masked using bullet points.
    /// </summary>
    public partial class DisplayWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the DisplayWindow class with registration data.
        /// </summary>
        /// <param name="data">The registration data to display. Must not be null.</param>
        /// <exception cref="ArgumentNullException">Thrown when data parameter is null.</exception>
        public DisplayWindow(RegistrationData data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data), "Registration data cannot be null.");
            }

            InitializeComponent();

            // Display the registration data in the labels
            lblFullName.Content = data.FullName ?? string.Empty;
            lblEmail.Content = data.Email ?? string.Empty;
            lblPhone.Content = data.Phone ?? string.Empty;
            lblUsername.Content = data.Username ?? string.Empty;
            
            // Mask the password with bullet points (•)
            lblPassword.Content = data.Password == null 
                ? string.Empty 
                : new string('•', data.Password.Length);
        }

        /// <summary>
        /// Handles the Close button click event.
        /// Closes the display window and returns to the main registration window.
        /// </summary>
        /// <param name="sender">The button that triggered the event.</param>
        /// <param name="e">Event arguments.</param>
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}