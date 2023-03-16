using BasketAppen.Views;

namespace BasketAppen;

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


    private async void OnClickedClock(object sender, EventArgs e)
    {
        while (true)
        {

            Clock.Text = TimeElapsed.Instance.GetElapsedTime().ToString();
            await Task.Delay(1000);
        }
    }

    

}

