namespace Dinosaurio;
///<Summary>
///<Createddate>1/07/2023</Createddate>
///<company>INDEL</company>
///<lastmodificationdate>1/07/2023</lastmodificationdate>
///<lastmodifierautor>Erika Chávez</lastmodifierautor>
///</Summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Constructor de la clase
	/// </summary>
	public MainPage()
	{
		InitializeComponent();
	}
    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(n.Text) || (!string.IsNullOrEmpty(peso.Text) ||
			(!string.IsNullOrEmpty(altura.Text))))
		{
			double pesokg, alturamts, pesolb, alturacms;

			pesokg = Convert.ToDouble(peso.Text);
			alturamts = Convert.ToDouble(altura.Text);

			pesolb = pesokg * 2.2046 / 1;
			alturacms = alturamts * 100 / 1;

			pesoL.Text = pesolb.ToString();
			Alturacm.Text = alturacms.ToString();
		}
		else
		{
			DisplayAlert("Error", "Introduce los datos requeridos", "Ok" );
		}
    }
}

