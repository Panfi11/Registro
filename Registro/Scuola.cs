using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro
{
    public class Scuola
    {
        private double voto;
        private string nome;
        List<Classe> classi = new List<Classe>();
        List<Materia> materie = new List<Materia>();


        public Scuola(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }

        public Classe CreateClasse(int anno, string sezione)
        {
            Classe classe = new Classe(anno, sezione);
            classi.Add(classe);
            return classe;
        }

        public List<Classe> GetClassi()
        {
            return classi;
        }

        public Materia CreateMateria(string nome)
        {
            Materia materia = new Materia(nome);
            materie.Add(materia);
            return materia;
        }

        public List<Materia> GetMaterie()
        {
            return materie;
        }
        public Votazione TrovaVotoMassimo()
        {
            Votazione max = classi[0].TrovaVotoMassimo();
            foreach (Classe c in classi)
            {
                Votazione v = c.TrovaVotoMassimo();
                if(v.voto > max.voto)
                {
                    max = v;
                }
            }
            return max;
        }
        public Votazione TrovaVotoMinimo()
        {
            Votazione min = classi[0].TrovaVotoMinimo();
            foreach (Classe c in classi)
            {
                Votazione v = c.TrovaVotoMinimo();
                if (v.voto < min.voto)
                {
                    min = v;
                }
            }
            return min;
        }



    }
}
