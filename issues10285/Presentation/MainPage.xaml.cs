namespace issues10285.Presentation;

public sealed partial class MainPage : Page
{
    public List<string> Names { get; } = new string[]
    {
            "Aaron",
            "Asmon",
            "Berry",
            "Lily",
            "Dave",
            "asddd",
            "Aaron",
            "Asmon",
            "Berry",
            "Lily",
            "Dave",
            "asddd",
            "Aaron",
            "Asmon",
            "Berry",
            "Lily",
            "Dave",
            "asddd",
            "Aaron",
            "Asmon",
            "Berry",
            "Lily",
            "Dave",
            "asddd",
            "Aaron",
            "Asmon",
            "Berry",
            "Lily",
            "Dave",
            "asddd",
            "Asmon",
            "Berry",
            "Lily",
            "Dave",
            "asddd",
            "Aaron",
            "Asmon",
            "Berry",
            "Lily",
            "Dave",
            "asddd",
            "Aaron",
            "Asmon",
            "Berry",
            "Lily",
            "Dave",
            "asddd",
            "Asmon",
            "Berry",
            "Lily",
            "Dave",
            "asddd",
            "Aaron",
            "Asmon",
            "Berry",
            "Lily",
            "Dave",
            "asddd",
            "Aaron",
            "Asmon",
            "Berry",
            "Lily",
            "Dave",
            "asddd",
            "Asmon",
            "Berry",
            "Lily",
            "Dave",
            "asddd",
            "Aaron",
            "Asmon",
            "Berry",
            "Lily",
            "Dave",
            "asddd",
            "Aaron",
            "Asmon",
            "Berry",
            "Lily",
            "Dave",
            "asddd",
            "Asmon",
            "Berry",
            "Lily",
            "Dave",
            "asddd",
            "Aaron",
            "Asmon",
            "Berry",
            "Lily",
            "Dave",
            "asddd",
            "Aaron",
            "Asmon",
            "Asmon",
            "Berry",
            "Lily",
            "Dave",
            "asddd",
    }.ToList();
    public MainPage()
    {
        DataContext = this;
        this.InitializeComponent();

    }

    private void Button_Click1(object sender, RoutedEventArgs e)
    {
        if (global::Microsoft.UI.Xaml.Window.Current.Content is FrameworkElement root)
        {
            root.RequestedTheme = ElementTheme.Light;
        }
    }
    private void Button_Click2(object sender, RoutedEventArgs e)
    {
        if (global::Microsoft.UI.Xaml.Window.Current.Content is FrameworkElement root)
        {
            root.RequestedTheme = ElementTheme.Dark;
        }
    }
}
