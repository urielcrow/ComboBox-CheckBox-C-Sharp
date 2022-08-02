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

namespace PildorasInformaticas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<SuperHeroe> superHeroes = new List<SuperHeroe> {
                new SuperHeroe{Id=1,Name="Peter Parker",Alias="SpiderMan",Power="ability" },
                new SuperHeroe{Id=2,Name="Bruce Banner",Alias="Hulk",Power="super strong" },
                new SuperHeroe{Id=3,Name="Wade Wilson",Alias="DeadPool",Power="regeneration" }
            };
            superHeroes.Add(new SuperHeroe { Id = 4, Name = "Jane Grey", Alias = "Phonex", Power = "telekinesis" });
            Heroes.ItemsSource = superHeroes;
          
        }

        private void AllCheckBoxs_Checked(object sender, RoutedEventArgs e)
        {
            ChangeState(true);
        }

        private void AllCheckBoxs_Unchecked(object sender, RoutedEventArgs e)
        {
            ChangeState(false);
        }

        private void VerifyAnyChecked(object sender, RoutedEventArgs e)
        {
            if (IronMan.IsChecked == true && BlackPanter.IsChecked == true && Falcon.IsChecked == true && Wolverin.IsChecked == true)
                AllCheckBoxs.IsChecked = true;
            else if (IronMan.IsChecked == true || BlackPanter.IsChecked == true || Falcon.IsChecked == true || Wolverin.IsChecked == true)
                AllCheckBoxs.IsChecked = null;
            else
                AllCheckBoxs.IsChecked = false;
        }

        private void ChangeState(bool status)
        {
            IronMan.IsChecked = status;
            BlackPanter.IsChecked = status;
            Falcon.IsChecked = status;
            Wolverin.IsChecked = status;
        }
    }

    public class SuperHeroe{
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Power { get; set; }

    }
}
