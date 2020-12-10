using System.Windows.Input;

namespace SuperheroesMVVM
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand Add = new RoutedUICommand(
            "Add", "Add", typeof(CustomCommands),
            new InputGestureCollection { new KeyGesture(Key.A, ModifierKeys.Control) }
            );

        public static readonly RoutedUICommand Clear = new RoutedUICommand(
            "Clear", "Clear", typeof(CustomCommands),
            new InputGestureCollection { new KeyGesture(Key.L, ModifierKeys.Control) }
            );
        public static readonly RoutedUICommand Previous = new RoutedUICommand(
            "Previous", "Previous", typeof(CustomCommands),
            new InputGestureCollection { new KeyGesture(Key.P, ModifierKeys.Control) }
            );

        public static readonly RoutedUICommand Next = new RoutedUICommand(
            "Next", "Next", typeof(CustomCommands),
            new InputGestureCollection { new KeyGesture(Key.N, ModifierKeys.Control) }
            );

    }
}
