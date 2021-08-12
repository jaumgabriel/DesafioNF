using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesafioNF_v2.Model;
using DesafioNF_v2.View;

namespace DesafioNF_v2.Controller
{
    class AutorController
    {
        private static ViewAutorCadastro janelaCadastroAutor;
        
        public static void IniciarCadastro()
        {
            janelaCadastroAutor = new ViewAutorCadastro();
            janelaCadastroAutor.ShowDialog();
        }
        public static void FecharCadastro()
        {
            janelaCadastroAutor.Close();
        }
        public static void Cadastrar(int codigo, string nome)
        {
            AutorModel novoAutor = new AutorModel();
            novoAutor.Codigo = codigo;
            novoAutor.Nome = nome;

            bool sucessoAutor = AutorModel.Salvar(novoAutor);

            if (sucessoAutor)
                {
                FecharCadastro();
                System.Windows.Forms.MessageBox.Show(
                        "Autor cadastrado com sucesso!",
                        "Sucesso"
                    );
                }
            else
                {
                System.Windows.Forms.MessageBox.Show(
                        "Erro ao cadastrar autor!"
                    );
            }
        }
        public static void IniciarRemocao()
        {

        }
        public static void FecharRemocao()
        {

        }
        public static void Remover()
        {

        }
        public static void Listar(System.Windows.Forms.DataGridView elementoVisualAutor)
        {
            /*
             * Elemento que falta implementar.
             * Elemento que busca as informações que precisamos no DB.
             
            elementoVisualAutor.DataSource = AutorModel.Buscar();
            */
        }
    }
}
