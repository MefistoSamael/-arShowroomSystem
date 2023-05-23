using CarShowroomSystem.ViewModels.Car;

namespace CarShowroomSystem.Views.Car;

public partial class ChangeCarPage : ContentPage
{
	public ChangeCarPage(ChangeCarViewModel vm)
	{
		BindingContext = vm;
		InitializeComponent();

        // ��������� ���������� ������ ���� ���������
        enginePicker.SelectedIndexChanged += vm.HandleSelectedIndexChangedEngine;
        gearboxPicker.SelectedIndexChanged += vm.HandleSelectedIndexChangedGearBox;
        wheelDrivePicker.SelectedIndexChanged += vm.HandleSelectedIndexChangedWheelDrive;
        datePicker.DateSelected += vm.HandleSelectedIndexChangedDateTime;
        checkBox.CheckedChanged += vm.HandleCheckedChanged;
    }
}