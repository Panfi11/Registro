using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro
{
    public class Studente
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public DateTime dataDiNascita { get; set; }

        public List<Votazione> Votazioni { get; private set; }
        public Studente(string nome, string cognome)
        {
            this.Nome = nome;
            this.Cognome = cognome;
        }

        public string GetNome()
        {
            return Nome;
        }

        public string GetCognome()
        {
            return Cognome;
        }

        public DateTime GetDataDiNascita()
        {
            return dataDiNascita;
        }

        public void SetDataDiNascita(DateTime data)
        {
            dataDiNascita = data;
        }

        public List<Votazione> GetVoti()
        {
            return Votazioni;
        }

        public void AddVoto(Votazione voto)
        {
            Votazioni.Add(voto);
        }
        public Votazione TrovaVotoMassimo()
        {
            Votazione max = Votazioni[0];
            for (int i = 0; i < Votazioni.Count; i++)
            {
                if (Votazioni[i].voto > max.voto)
                {
                    max = Votazioni[i];
                }
             
            }
            return max;
            
        }
        public Votazione TrovaVotoMinimo()
        {
            Votazione min = Votazioni[0];
            for (int i = 0; i < Votazioni.Count; i++)
            {
                if (Votazioni[i].voto > min.voto)
                {
                    min = Votazioni[i];
                }

            }
            return min;

        }



    }
}
