namespace MauiDemoDel2_2;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}


    private async void OnImageButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.EBPage());
    }

    private async void OnClickedGoTeamPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.NBAPage());
    }

}

