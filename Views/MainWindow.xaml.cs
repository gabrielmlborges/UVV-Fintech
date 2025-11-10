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

namespace UVV_FINTECH
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {

        private readonly ContaService _contaService;

        public MainWindow()
        {
            InitializeComponent();

            _contaService = new ContaService(new FintechContext());
        }
    }

    private void BotaoEntrar_Click(object sender, RoutedEventArgs e)
    {
        string nome = Email.text;
        string cpf = 123;
        string senha Senha.text;

        var NovaConta = _contaService.CriarConta(nome, cpf, senha);

        if (conta != null)
        {
            MessageBox.Show(
                $"✅ Conta criada com sucesso!\n" +
                $"ID: {conta.ContaId}\n" +
                $"Nome: {conta.NomeDono}\n" +
                $"Saldo: {conta.Saldo:C}",
                "Sucesso",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }
        else {
            MessageBox.Show("### ERROR ###");
        }
    }
}
