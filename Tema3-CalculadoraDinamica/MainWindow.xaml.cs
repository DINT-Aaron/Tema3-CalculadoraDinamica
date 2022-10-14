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

namespace Tema3_CalculadoraDinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            crearBotones();
        }

        private void crearBotones()
        {
            for(int i = 1; i < 10; i++)
            {
                Button btn = new Button();
                btn.Tag = i;
                Viewbox vb = new Viewbox();
                TextBlock tb = new TextBlock();
                tb.Text = i.ToString();
                vb.Child = tb;
                btn.Content = vb;
                contenedorUniformGrid.Children.Add(btn);
            } 
                        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pantallaTextBlock.Text += (sender as Button).Tag;
        }
    }
}
