using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.Messaging;
using CarShowroomSystem.ViewModels;
using System.Xml.Linq;
using CarShowroomSystem.Model;

namespace CarShowroomSystem.Views;

public partial class LoginPage : ContentPage
{
    // �����������, ������������ ��� �������� �� ��������
    public LoginPage(LoginViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }

}