namespace ContadorManual;

public partial class MainPage : ContentPage
{
	private int _conteo;

	public MainPage()
	{
		InitializeComponent();
		_conteo = 0;
        ConteoLabel.Text = _conteo.ToString();
	}

    private void OnContarButtonclicked(object sender, EventArgs e)
    {
        int rango = (int) RangoDelConteoSlider.Value;
        _conteo+= rango;
        ConteoLabel.Text = _conteo.ToString();
    }

    private void OnReiniciarButtonClicked(object sender, EventArgs e)
    {
        _conteo = 0;
        ConteoLabel.Text = _conteo.ToString();
    }
}

