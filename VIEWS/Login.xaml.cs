using Microsoft.Maui.Graphics;

namespace mjacomeExamen.VIEWS;

public partial class Login : ContentPage
{
    private Dictionary<string, string> usuarios;
    public Login()
    {
        InitializeComponent();

        usuarios = new Dictionary<string, string>
        {
    { "estudiante", "moviles" },
    { "uisrael", "2024" }
        };
    }


    private void BtnLogin_Clicked(object sender, EventArgs e)
    {
        string usuario = TxtUsuario.Text;
        string contrasena = TxtContrasena.Text;

        if (usuario !=null && contrasena != null) {

            if (usuarios.TryGetValue(usuario, out string password) && contrasena == password)
            {
                Navigation.PushAsync(new VIEWS.Registro(usuario));
            }
            else
            {
                DisplayAlert("Error", "Usuario/Contraseña Incorrecta", "Cerrar");
            }
        }
        else
        {
            DisplayAlert("Error", "Ingresa tu Usuario y Contraseña", "Cerrar");
        }
    }
}