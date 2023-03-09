using MauiDemoDel2_2.Models;

namespace MauiDemoDel2_2.Views;

public partial class ShopDetailsPage : ContentPage
{
	public ShopDetailsPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.ShopDetailsPageViewModel();


    }

    private void OnBackClicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
    
    private void Button_Clicked(object sender, EventArgs e)
    {
        
    }
    

}