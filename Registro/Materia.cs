using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro
{
    public class Materia
    {
        public string Nome { get; private set; }

        public Materia(string nome)
        {
            Nome = nome;
        }

        public string GetNome()
        {
            return Nome;
        }
    }
}
