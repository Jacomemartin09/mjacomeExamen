namespace mjacomeExamen.VIEWS;

public partial class Resumen : ContentPage
{

	public Resumen(string usuario, 
		string montoInicial, 
		string pagoMensual, 
		string pagoTotal, 
		string fecha, 
		string Pais, 
		string Ciudad, 
		string Nombre, 
		string Apellido, 
		string Edad)

	{
		InitializeComponent();
		UsuarioLabel2.Text = "Usuario conectado: " + usuario;

        LNombre.Text = Nombre;
        LApellido.Text = Apellido;
        LEdad.Text = Edad;
        LFecha.Text = fecha;
        LCiudad.Text = Ciudad;
        LPais.Text = Pais;
        LMontoInicial.Text = montoInicial;
        LPagoMensual.Text = pagoMensual;
        LPagoTotal.Text = pagoTotal;


    }
}