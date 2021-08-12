using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioNF_v2.Model
{
    class AutorModel
    {
        /*  Atributos responsaveis por identificar o Autor.
            Cada autor tem um codigo e um nome.
        */
        private string codigo;
        public string Codigo
        {
            get { return codigo;}
            set {codigo = value;}
        }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = Nome; }
        }

        //  Responsavel por armazenar os dados do autor.
        public static bool Salvar(AutorModel novoAutor)
        {
            return false;
        }
        public static bool Editar(AutorModel qualAutor)
        {
            return false;
        }
        public static bool Remover(AutorModel qualAutor)
        {
            return false;
        }
    }
}
