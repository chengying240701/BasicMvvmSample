namespace BasicMvvmSample.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static

    // Add our SimpleViewModel.
    // Note: We need at least a get-accessor for our Properties.
    public SimpleViewModel SimpleViewModel { get; } = new SimpleViewModel();
}
