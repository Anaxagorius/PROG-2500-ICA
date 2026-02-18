using System.Windows;
using System.Windows.Controls;

namespace UserRegistrationWPF.CustomControls
{
    /// <summary>
    /// Custom themed TextBox control that applies a consistent visual style.
    /// Inherits from the standard WPF TextBox and overrides the default style.
    /// The actual style definition is defined in Themes/Generic.xaml.
    /// </summary>
    public class ThemedTextBox : TextBox
    {
        /// <summary>
        /// Static constructor that overrides the default style metadata for ThemedTextBox.
        /// This ensures that the custom style from Generic.xaml is applied to all instances.
        /// </summary>
        static ThemedTextBox()
        {
            // Override the default style to use our custom themed style
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(ThemedTextBox),
                new FrameworkPropertyMetadata(typeof(ThemedTextBox)));
        }
    }
}