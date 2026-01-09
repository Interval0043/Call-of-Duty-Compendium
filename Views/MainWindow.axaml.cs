using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;
using CODC.ViewModels;

namespace CODC.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void AboutViewClick(object sender, RoutedEventArgs e)
    {
        maincont.Content = new AboutView();
    }
}