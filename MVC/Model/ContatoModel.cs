using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVC.Model
{
    internal class ContatoModel
    {
        private static List<Contato> contatos = new List<Contato>();

        public void AddContato(Contato contato)
        {
            contatos.Add(contato);
        }
        public List<Contato> GetContatos()
        {
            return contatos;
        }
    }
}
   

