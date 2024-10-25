namespace mjacomeExamen.VIEWS;

public partial class Registro : ContentPage
{
    decimal pagoMensual;
    decimal montoInicial;
    public Registro(string usuario)
    {
        InitializeComponent();
        UsuarioLabel.Text = $"Usuario Conectado: {usuario}";
    }

    private void BtnCalcular_Clicked(object sender, EventArgs e)
    {
        if (pkPais.SelectedIndex == -1)
        {
            DisplayAlert("Error", "Debe seleccionar País", "OK");
            return;
        }

        if (pkCiudad.SelectedIndex == -1)
        {
            DisplayAlert("Error", "Debe seleccionar Ciudad", "OK");
            return;
        }

        if (string.IsNullOrEmpty(TxtNombre.Text))
        {
            DisplayAlert("Error", "Debe ingresar Nombre", "OK");
            return;
        }

        if (string.IsNullOrEmpty(TxtApellido.Text))
        {
            DisplayAlert("Error", "Debe ingresar Apellido", "OK");
            return;
        }

        if (string.IsNullOrEmpty(TxtEdad.Text))
        {
            DisplayAlert("Error", "Debe ingresar Edad", "OK");
            return;
        }

        if (pkFecha.Date < DateTime.Now)
        {
            DisplayAlert("Error", "La fecha debe ser mayor a la actual", "OK");
            return;
        }

        if (string.IsNullOrEmpty(TxtMontoInicial.Text))
        {
            DisplayAlert("Error", "Debe calcular el pago", "OK");
            return;
        }

        decimal pagoTotal = pagoMensual * 4 + montoInicial;

        Navigation.PushAsync(new Resumen(UsuarioLabel.Text, TxtMontoInicial.Text, TxtPagoMensual.Text, pagoTotal.ToString(), pkFecha.Date.ToString("dd-MM-yyyy"), pkPais.SelectedItem.ToString(), pkCiudad.SelectedItem.ToString(), TxtNombre.Text, TxtApellido.Text, TxtEdad.Text));
    }



    private void BtnCalcularPMensual_Clicked(object sender, EventArgs e)
    {
        if (decimal.TryParse(TxtMontoInicial.Text, out montoInicial))
        {
            if (montoInicial < 1 || montoInicial > 1499)
            {
                DisplayAlert("Error", "El monto inicial debe estar entre 1 y 1499", "OK");
                return;
            }
        }
        else
        {
            DisplayAlert("Error", "Ingrese un monto inicial válido", "OK");
            return;
        }

        decimal porcentaje = 1500 * 0.04m;
        pagoMensual = (1500 - montoInicial) / 4 + porcentaje;
        TxtPagoMensual.Text = pagoMensual.ToString("F2");


    }

}

