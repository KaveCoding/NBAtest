namespace MauiDemoDel2_2.Views;

public partial class Lagdetaljer : ContentPage
{
	public Lagdetaljer()
	{
		InitializeComponent();
	}
    private void OnBackClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}