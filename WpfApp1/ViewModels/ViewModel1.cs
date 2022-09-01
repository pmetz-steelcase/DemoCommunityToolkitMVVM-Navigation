using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using WpfApp1.Messages;

namespace WpfApp1.ViewModels;

public partial class ViewModel1 : ObservableObject
{
    [ObservableProperty]
    private string textBoxText;

    private ObservableObject AlternativeVM;

    public ViewModel1()
    {
        TextBoxText = "Enter text";
    }

    public ViewModel1(ObservableObject altVM)
    {
        // store the ViewModel2 object we have received
        AlternativeVM = altVM;
    }

    [RelayCommand]
    private void SwitchToView2()
    {
        // if alt vm hasnt been created, do it now
        if (AlternativeVM == null)
            AlternativeVM = new ViewModel2(this);
        WeakReferenceMessenger.Default.Send(new ChangeViewModelMessage(AlternativeVM));
    }
}