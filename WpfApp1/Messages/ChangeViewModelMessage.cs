using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace WpfApp1.Messages;

public class ChangeViewModelMessage : ValueChangedMessage<ObservableObject>
{
    public ChangeViewModelMessage(ObservableObject viewModel) : base(viewModel)
    {
    }
}
