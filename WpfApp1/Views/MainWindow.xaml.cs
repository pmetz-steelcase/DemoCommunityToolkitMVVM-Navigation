using System.Windows;
using WpfApp1.ViewModels;

namespace WpfApp1.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        // why do i have to set the data context here? it didn't work in MainWindow.xaml like it did for View1.xaml
        DataContext = new MainWindowViewModel(); 
    }
}
