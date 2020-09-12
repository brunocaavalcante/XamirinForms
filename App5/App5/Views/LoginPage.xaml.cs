using App5.Models;
using App5.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private readonly UserService _service;
        public LoginPage()
        {
            InitializeComponent();
            btnLogin.Clicked += BtnLogin_Clicked;
            _service = new UserService();
        }

        private void BtnLogin_Clicked(object sender, System.EventArgs argts)
        {
           
            if (txtLogin.Text != "" && txtSenha.Text != "")
            {
                UserModel user = new UserModel();
                user.Login = txtLogin.Text;
                user.Senha = txtSenha.Text;
                user.Nome = "Teste";
                user.Id = Guid.NewGuid();
                var result = _service.FazerLogin(user);
            }
                
        }
    }
}