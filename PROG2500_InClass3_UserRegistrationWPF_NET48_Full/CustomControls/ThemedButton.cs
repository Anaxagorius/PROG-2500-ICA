using System.Windows;
using System.Windows.Controls;

namespace UserRegistrationWPF.CustomControls
{
    /// <summary>
    /// Custom themed Button control that applies a consistent visual style.
    /// Inherits from the standard WPF Button and overrides the default style.
    /// The actual style definition is defined in Themes/Generic.xaml.
    /// </summary>
    public class ThemedButton : Button
    {
        /// <summary>
        /// Static constructor that overrides the default style metadata for ThemedButton.
        /// This ensures that the custom style from Generic.xaml is applied to all instances.
        /// </summary>
        static ThemedButton()
        {
            // Override the default style to use our custom themed style
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(ThemedButton),
                new FrameworkPropertyMetadata(typeof(ThemedButton)));
        }
    }
}