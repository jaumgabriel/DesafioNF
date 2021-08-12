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
    public partial class ViewGêneroCadastro : Form
    {
        public ViewGêneroCadastro()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneroController.Cadastrar(
                textBox1.Text,
                maskedTextBox1.Text) ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GeneroController.FecharCadastro();
        }
    }
}
