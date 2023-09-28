using CorreiosWSDL.modelo;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CorreiosWSDL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, RoutedEventArgs e)
        {
            Controle controle = new Controle();
            Endereco endereco = controle.pesquisarEndereco(txbCep.Text);
            if (controle.mensagem.Equals(""))
            {
                txbLogradouro.Text = endereco.logradouro;
                txbBairro.Text = endereco.bairro;
                txbCidade.Text = endereco.cidade;
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

            

        }
    }
}
