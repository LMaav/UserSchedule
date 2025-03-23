using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Model
{
    internal class Contato
    {
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }

        public Contato(string nome, int telefone, string email)
        {
            Nome = nome;
            this.Telefone = telefone;
            Email = email;
        }
    }
    
}
