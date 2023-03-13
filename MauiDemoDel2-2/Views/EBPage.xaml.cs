namespace MauiDemoDel2_2.Views;

public partial class EBPage : ContentPage
{
	public EBPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.EBPageViewmodel();
    }
}