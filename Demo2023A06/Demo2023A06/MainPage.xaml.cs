using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo2023A06
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.lvDemoDinamico.ItemsSource = null;
            List<string> personas = new List<string>();
            personas.Add("Hugo Torrico");
            personas.Add("Paco Torrico");
            personas.Add("Luis Marquez");
            personas.Add("Juan Marquez");
            personas.Add("José Gamarra");

            
            var personasFinal = personas.Where(x => x.Contains(txtFiltro.Text)).ToList();

            this.lvDemoDinamico.ItemsSource = personasFinal;

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            lvDemoDinamico.ItemsSource = null;
        }
    }
}
