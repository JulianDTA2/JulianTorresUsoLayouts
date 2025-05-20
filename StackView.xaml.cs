namespace JulianTorresUsoLayouts;

public partial class StackView : ContentPage
{
	public StackView()
	{
		InitializeComponent();
	}

    private void BotonIrAFlex_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new FlexView());

    }
}