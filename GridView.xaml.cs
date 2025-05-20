namespace JulianTorresUsoLayouts;

public partial class GridView : ContentPage
{
	public GridView()
	{
		InitializeComponent();
	}
    private void BotonIrAStack_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new StackView());

    }
}