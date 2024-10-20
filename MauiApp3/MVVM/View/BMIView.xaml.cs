using MauiApp3.MVVM.ViewModel;

namespace MauiApp3.MVVM.View;

public partial class BMIView : ContentPage
{
	public BMIView()
	{
		InitializeComponent();
		BindingContext = new BMIViewModel();
	}
}
