using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using WpfApp1.Messages;

namespace WpfApp1.ViewModels;

public partial class MainWindowViewModel : ObservableObject, IRecipient<ChangeViewModelMessage>
{

    [ObservableProperty]
    public ObservableObject currentViewModel;

    public MainWindowViewModel()
    {
        CurrentViewModel = new ViewModel1();
        WeakReferenceMessenger.Default.Register<ChangeViewModelMessage>(this);
    }

    public void Receive(ChangeViewModelMessage message)
    {
        CurrentViewModel = message.Value;
    }
}
