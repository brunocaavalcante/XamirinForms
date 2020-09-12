using System;
using System.Collections.Generic;
using System.Text;

namespace App5.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
