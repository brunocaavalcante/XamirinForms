using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void Visualizar_Clicked(object sender, EventArgs e)
        {

        }

        private async Task Cadastro_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewItemPage());
        }

        private void Relatorio_Clicked(object sender, EventArgs e)
        {

        }
    }
}