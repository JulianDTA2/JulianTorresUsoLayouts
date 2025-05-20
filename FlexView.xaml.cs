namespace JulianTorresUsoLayouts;

public partial class FlexView : ContentPage
{
	public FlexView()
	{
		InitializeComponent();
	}
    private void BotonIrAAbsolute_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new AbsoluteView());
    }
}