using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UVV_FINTECH.view
{
    /// <summary>
    /// Lógica interna para Registro.xaml
    /// </summary>
    public partial class Registro : Window
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void InsiraNovoNome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //Registra Nova Conta no BD
        private void BotaoNovoRegistrar_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        //Se ja possui conta, entra na tela de login
        private void BotaoPossuiLogin_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
