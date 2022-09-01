using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using WpfApp1.Messages;

namespace WpfApp1.ViewModels;

public partial class ViewModel2 : ObservableObject
{
    [ObservableProperty]
    private string textBoxText;

    public ViewModel2()
    {
        TextBoxText = "Enter text";
    }

    [RelayCommand]
    private void SwitchToView1()
    {
        WeakReferenceMessenger.Default.Send(
            new ChangeViewModelMessage(new ViewModel1()));
    }
}
