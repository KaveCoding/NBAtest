namespace MauiDemoDel2_2.Views;

public partial class NBAPage : ContentPage
{
	public NBAPage()
	{
		InitializeComponent();
	}
    private async void OnClickedGoTeamPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.ShopPage());
    }

    private async void OnClickedGoPlayerPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Playerpage());
    }

}