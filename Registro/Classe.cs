using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro
{
    public class Classe
    {
        public int Anno { get; private set; }
        public string Sezione { get; private set; }
        public List<Studente> Studenti { get; private set; } = new List<Studente>();


        public Classe(string sezione, int anno)
        {
            Anno = anno;
            Sezione = sezione;
        }
        public string Nome
        {
            get
            {
                return Anno + Sezione;
            }
        }
        public void AddStudente(Studente Paf)
        {
            Studenti.Add(Paf);

        }
        public Votazione TrovaVotoMassimo()
        {
            Votazione max = Studenti[0].TrovaVotoMassimo();
            foreach (Studente Paf in Studenti)
            {
                Votazione v = Paf.TrovaVotoMassimo();
                if (v.voto > max.voto)
                {
                    max = v;
                }
                    
            }
            return max;
        }
        public Votazione TrovaVotoMinimo()
        {
            Votazione min = Studenti[0].TrovaVotoMinimo();
            foreach (Studente Paf in Studenti)
            {
                Votazione v = Paf.TrovaVotoMinimo();
                if (v.voto < min.voto)
                    min = v;
            }
        }
    }
    
}
