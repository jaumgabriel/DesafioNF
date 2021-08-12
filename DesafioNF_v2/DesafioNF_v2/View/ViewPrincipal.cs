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

namespace DesafioNF_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrarAutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutorController.IniciarCadastro();
        }

        private void cadastrarGênerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneroController.IniciarCadastro();
        }
    }
}
