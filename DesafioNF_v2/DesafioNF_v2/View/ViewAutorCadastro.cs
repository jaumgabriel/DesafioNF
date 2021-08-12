using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DesafioNF_v2.Controller;
namespace DesafioNF_v2.View
{
    public partial class ViewAutorCadastro : Form
    {
        public ViewAutorCadastro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutorController.FecharCadastro();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutorController.Cadastrar(
                textBox1.Text,
                maskedTextBox1.Text);
        }
    }
}
