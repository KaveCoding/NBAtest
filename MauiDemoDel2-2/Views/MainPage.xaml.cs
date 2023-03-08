namespace MauiDemoDel2_2;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnClickedClock(object sender, EventArgs e)
	{
		while(true)
		{
			Clock.Text = DateTime.Now.ToString();
			await Task.Delay(1000);
		}
	}



    private async void OnClickedGoTeamPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.ShopPage());
    }

}

