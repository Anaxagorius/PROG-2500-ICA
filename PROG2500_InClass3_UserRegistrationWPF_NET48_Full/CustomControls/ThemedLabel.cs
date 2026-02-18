using System.Windows;
using System.Windows.Controls;

namespace UserRegistrationWPF.CustomControls
{
    /// <summary>
    /// Custom themed Label control that applies a consistent visual style.
    /// Inherits from the standard WPF Label and overrides the default style.
    /// The actual style definition is defined in Themes/Generic.xaml.
    /// </summary>
    public class ThemedLabel : Label
    {
        /// <summary>
        /// Static constructor that overrides the default style metadata for ThemedLabel.
        /// This ensures that the custom style from Generic.xaml is applied to all instances.
        /// </summary>
        static ThemedLabel()
        {
            // Override the default style to use our custom themed style
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(ThemedLabel),
                new FrameworkPropertyMetadata(typeof(ThemedLabel)));
        }
    }
}