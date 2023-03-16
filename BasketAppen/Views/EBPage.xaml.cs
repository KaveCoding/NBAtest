using BasketAppen.ViewModels;

namespace BasketAppen.Views;

public partial class EBPage : ContentPage
{
	public EBPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.EBPageViewmodel();


    }


    bool pageStarted = false;
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if (!pageStarted)
        {
            Task t = (BindingContext as EBPageViewmodel).GetLagmedlemmar(); // Metod i ViewModel
            pageStarted = true;
        }
    }



    private async void OnListViewitemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var product = ((ListView)sender).SelectedItem as Models.Lagmedlem;
        if (product != null)
        {
            var page = new Lagdetaljer();
            page.BindingContext = product;
            await Navigation.PushAsync(page);
        }


    }
}