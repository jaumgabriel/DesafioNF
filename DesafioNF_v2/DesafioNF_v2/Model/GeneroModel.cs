using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioNF_v2.Model
{
    class GeneroModel
    {
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = Codigo; }
        }
        private string genero;
        public string Genero
        {
            get { return genero; }
            set { Genero = genero; }
        }
        public static bool Salvar(GeneroModel novoGenero)
        {
            return false;
        }
        public static bool Remover(GeneroModel qualGenero)
        {
            return false;
        }
    }
}
