using BasketAppen.ViewModels;

namespace BasketAppen.Views;

public partial class TeamPage : ContentPage
{
	public TeamPage()
	{
		InitializeComponent();
        BindingContext = new TeampageViewModel();
    }

    private async void OnListViewitemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var product = ((ListView)sender).SelectedItem as Models.Team;
        if (product != null)
        {
            var page = new TeamDetailsPage();
            page.BindingContext = product;
            await Navigation.PushAsync(page);
            
            
        }


    }
}