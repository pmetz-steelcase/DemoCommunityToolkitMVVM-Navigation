﻿using System.Windows;
using WpfApp1.ViewModels;

namespace WpfApp1.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        DataContext = new MainWindowViewModel(); // TODO: move to xaml
        InitializeComponent();
    }
}
