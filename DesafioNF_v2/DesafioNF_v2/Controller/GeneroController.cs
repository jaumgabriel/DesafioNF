using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesafioNF_v2.Model;
using DesafioNF_v2.View;

namespace DesafioNF_v2.Controller
{
    class GeneroController
    {
        private static ViewGêneroCadastro janelaCadastroGenero;

        public static void IniciarCadastro()
        {
            janelaCadastroGenero = new ViewGêneroCadastro();
            janelaCadastroGenero.ShowDialog();

        }
        public static void FecharCadastro()
        {
            janelaCadastroGenero.Close();
        }
        public static void Cadastrar(int codigo, string genero)
        {
            GeneroModel novoGenero = new GeneroModel();
            novoGenero.Codigo = codigo;
            novoGenero.Genero = genero;

            bool sucessoGenero = GeneroModel.Salvar(novoGenero);

            if (sucessoGenero)
            {
                FecharCadastro();
                System.Windows.Forms.MessageBox.Show(
                    "Genero cadastrado com sucesso!",
                    "Sucesso!"
                    );
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Erro ao cadastrar gênero!");
            }
        }
    }
}