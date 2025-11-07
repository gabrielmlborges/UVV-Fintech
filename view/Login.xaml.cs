using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UVV_FINTECH.view;

namespace UVV_FINTECH
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Senha_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //Verifica no BD se a conta existe
        private void BotaoEntrar_Click(object sender, RoutedEventArgs e)
        { 
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
            this.Close();
        }

        //Vai para a tela de Registrar conta
        private void BotaoRegistrar_Click(object sender, RoutedEventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Close();
        }
    }
}