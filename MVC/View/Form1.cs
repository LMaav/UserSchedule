using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC.Controller;
using MVC.Model;

namespace MVC
{
    public partial class Form1 : Form
    {
        private ContatoController controller = new ContatoController();
        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshDTG()
        {
            List<Contato> contatos = controller.GetAllContatos();
            dtg_Contatos.DataSource = null;
            dtg_Contatos.DataSource = contatos;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string nome = txt_Nome.Text;
            string telefone = txt_Telefone.Text;
            string email = txt_Email.Text;
            string msg = controller.SaveContato(nome, telefone, email);
            MessageBox.Show(msg);
            this.RefreshDTG();
        }
    }
}
