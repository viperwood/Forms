using System;
using System.IO;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Avalonia.Skia.Helpers;
using Path = Avalonia.Controls.Shapes.Path;

namespace Forms;

public partial class RegistrationWindow : Window
{
    public RegistrationWindow()
    {
        InitializeComponent();
        StapTwo.IsVisible = false;
    }

    private void CloseWindow(object? sender, TappedEventArgs e)
    {
        Close();
    }

    private void CloseEvent(object? sender, TappedEventArgs e)
    {
        BorderEvent.IsVisible = false;
    }


    private void SendCodeButton(object? sender, RoutedEventArgs e)
    {
        FerstStapReg.IsVisible = false;
        SecondStapReg.IsVisible = true;
    }

    private void ConfirmButton(object? sender, RoutedEventArgs e)
    {
        SecondStapReg.IsVisible = false;
        ThirdStapReg.IsVisible = true;
    }

    private void RegisterButton(object? sender, RoutedEventArgs e)
    {
        ProfileInfoWindow profileInfoWindow = new();
        profileInfoWindow.Show();
        Close();
    }
}