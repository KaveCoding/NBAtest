using MauiDemoDel2_2.ViewModels;

namespace MauiDemoDel2_2.Views;

public partial class ShopPage : ContentPage
{
	public ShopPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.ShopPageViewModel();
    }

    private async void OnListViewitemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var product = ((ListView)sender).SelectedItem as Models.Team;
        if (product != null)
        {
            var page = new ShopDetailsPage();
            page.BindingContext = product;
            await Navigation.PushAsync(page);
            
            
        }


    }
}