namespace mjacomeExamen.VIEWS;

public partial class Registro : ContentPage
{
	
    public Registro(string usuario)
    {
        InitializeComponent();
        UsuarioLabel.Text = $"Usuario Conectado: {usuario}";
    }

    private void BtnCalcular_Clicked(object sender, EventArgs e)
    {

    }
}