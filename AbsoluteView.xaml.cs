namespace JulianTorresUsoLayouts;

public partial class AbsoluteView : ContentPage
{
	public AbsoluteView()
	{
		InitializeComponent();
	}

    private void Regresar_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new GridView());

    }
}