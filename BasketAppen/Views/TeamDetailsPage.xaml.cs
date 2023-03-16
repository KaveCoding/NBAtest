using BasketAppen.Models;

namespace BasketAppen.Views;

public partial class TeamDetailsPage : ContentPage
{
	public TeamDetailsPage()
	{
		InitializeComponent();
        

    }

    private void OnBackClicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
    
    
    

}