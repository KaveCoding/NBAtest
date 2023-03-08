using MauiDemoDel2_2.Models;

namespace MauiDemoDel2_2.Views;

public partial class ShopDetailsPage : ContentPage
{
	public ShopDetailsPage()
	{
		InitializeComponent();
		
	}

    private void OnBackClicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
    
    private void Button_Clicked(object sender, EventArgs e)
    {
        
    }
    private async void OnListViewitemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var product = ((ListView)sender).SelectedItem as Team;
        if (product != null)
        {
            var page = new ShopDetailsPage();
            page.BindingContext = product;
            await Navigation.PushAsync(page);


        }


    }

}