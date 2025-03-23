using MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controller
{
    internal class ContatoController
    {
        private ContatoModel model = new ContatoModel();

        public string SaveContato(string nome, string telefone, string email)
        {
            if (string.IsNullOrWhiteSpace(nome)||string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(email))
            {
                return "Digite os dados necessários";
            }
            if (!int.TryParse(telefone, out int telefoneConvert))
            {
                return "Telefone inválido";
            }
            Contato contato = new Contato(nome, telefoneConvert, email);
            model.AddContato(contato);
            return "Contato Salvo com sucesso!";
        }
        public List<Contato> GetAllContatos()
        {
            return model.GetContatos();
        }
    }
    
}
