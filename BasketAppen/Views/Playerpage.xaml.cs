using BasketAppen.ViewModels;
namespace BasketAppen.Views;

public partial class Playerpage : ContentPage
{
	public Playerpage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.PlayerPageViewModel();
    }


    bool pageStarted = false;
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if (!pageStarted)
        {
            Task t = (BindingContext as PlayerPageViewModel).GetPlayers(); // Metod i ViewModel
            pageStarted = true;
        }
    }


    private async void OnListViewitemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var product = ((ListView)sender).SelectedItem as Response;
        if (product != null)
        {
            var page = new Playerdetails();
            page.BindingContext = product;
            await Navigation.PushAsync(page);
        }


    }





}