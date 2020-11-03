using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro
{
    public class Votazione
    {
        private double voto;
        private DateTime data;
        private Materia materia;

        public Votazione(double voto, Studente studente, Materia materia)
        {
            this.voto = voto;
            studente.AddVoto(this);
            this.materia = materia;
        }
        public Votazione GetVoto()
        {
            return this;
        }

        public Materia GetMateria()
        {
            return materia;
        }

        public DateTime GetData()
        {
            return data;
        }

        public double GetVotoDouble()
        {
            return voto;
        }

        public bool IsSuficiente()
        {
            if (voto >= 6)
                return true;
            else return false;
        }


    }
}
