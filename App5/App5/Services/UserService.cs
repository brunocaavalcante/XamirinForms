using App5.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5.Services
{
    public class UserService
    {
        FirebaseClient cliente;
        public UserService()
        {
            cliente = new FirebaseClient("https://fir-login-7c5c5.firebaseio.com/");
        }

        public async Task<bool> UsuarioExiste(Guid Id)
        {
            var user = (await cliente.Child("Usuarios")
                .OnceAsync<UserModel>())
                .Where(u => u.Object.Id == Id)
                .FirstOrDefault();

            return (user != null);
        }

        public async Task<bool> RegistrarUsuario(UserModel usuario)
        {
            if (await UsuarioExiste(usuario.Id) || usuario == null) return false;

            await cliente.Child("Usuarios")
                .PostAsync(usuario);

            return true;
        }

        public async Task<bool> FazerLogin(UserModel usuario)
        {
            var user = (await cliente.Child("Usuarios")
                .OnceAsync<UserModel>())
                .Where(u => u.Object.Login.Equals(usuario.Login) && u.Object.Senha.Equals(usuario.Senha))
                .FirstOrDefault();

            return (user != null);
        }
    }
}
