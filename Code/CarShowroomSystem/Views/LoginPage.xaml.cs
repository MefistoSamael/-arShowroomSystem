using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.Messaging;
using CarShowroomSystem.ViewModels;
using System.Xml.Linq;
using CarShowroomSystem.Model;

namespace CarShowroomSystem.Views;

public partial class LoginPage : ContentPage
{
    // ��������� dependecy injection �� ��������, ��� ����� ��� �����,
    // ����� ��� ������������: ���� �� �������������� �������� ��������(��� ������� ��������� ����� �������
    // ������ ��� �������� � ���� �������������), ������ - ���� �� �������� �������� �� ������ ��������(���
    // ����� � ������� � ����� �����)


    LoginViewModel vm;
    // �����������, ������������ ��� �������� �� ��������
    public LoginPage(LoginViewModel vm)
    {
        this.vm = vm;

        BindingContext = vm;
        InitializeComponent();
    }

    //��� �������� Application.Current.MainPage = new AppShell();
    public LoginPage()
    {

    }
}