using MGG.ExcelHelper;
using Microsoft.Win32;
using System;
using System.Windows;
using WPFBlitz.src;

namespace WPFBlitz
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelectSheet(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Title = "Procurar arquivos no computador";

            fileDialog.Filter = "Arquivos texto (*.xlsx)|*.xlsx|Todos os arquivos (*.*)|*.*";

            fileDialog.ShowDialog();

            txtWay.Text = fileDialog.FileName;
        }

        private void Run(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtWay.Text))
                {
                    MessageBox.Show("Campo da planilha encontrasse vazio", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    var manager = new ManagerExcel<Excel>(txtWay.Text);

                    var data = manager.ReadExcel();

                    Runner.Begin(data);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
        }
    }
}
