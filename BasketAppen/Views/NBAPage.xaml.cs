namespace BasketAppen.Views;

public partial class NBAPage : ContentPage
{
	public NBAPage()
	{
		InitializeComponent();
	}
    private async void OnClickedGoTeamPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TeamPage());
    }

    private async void OnClickedGoPlayerPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Playerpage());
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