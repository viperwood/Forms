using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Forms;

public partial class ProfileInfoWindow : Window
{
    public ProfileInfoWindow()
    {
        InitializeComponent();
    }
    
    private void CloseWindow(object? sender, TappedEventArgs e)
    {
        Close();
    }

    private void GoNextButtonSecond(object? sender, RoutedEventArgs e)
    {
        SecondStapProfileInfo.IsVisible = false;
        ThirdStapProfileInfo.IsVisible = true;
    }

    private void GoNextButtonFerst(object? sender, RoutedEventArgs e)
    {
        FerstStapProfileInfo.IsVisible = false;
        SecondStapProfileInfo.IsVisible = true;
    }
}