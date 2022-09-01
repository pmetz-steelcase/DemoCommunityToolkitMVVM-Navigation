using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using WpfApp1.Messages;

namespace WpfApp1.ViewModels;

public partial class ViewModel1 : ObservableObject
{
    [ObservableProperty]
    private string textBoxText;

    public ViewModel1()
    {
        TextBoxText = "Enter text";
    }

    [RelayCommand]
    private void SwitchToView2()
    {
        WeakReferenceMessenger.Default.Send(
            new ChangeViewModelMessage(new ViewModel2()));
    }
}
