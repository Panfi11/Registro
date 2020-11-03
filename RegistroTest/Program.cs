using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Scuola scuola = new Scuola("Rosselli_Rasetti");
            Classe classe = scuola.CreateClasse(4, "AI");
            Studente studente1 = new Studente("miao", "bau");
            Studente studente2 = new Studente("pino", "frontani");
            classe.AddStudente(studente1);
            classe.AddStudente(studente2);
            Materia materia1 = new Materia("REligione");
            Votazione voto1 = new Votazione(8, studente1, materia1);
            Votazione voto2 = new Votazione(7, studente2, materia1);
            Votazione votomax = scuola.TrovaVotoMassimo();
            Console.WriteLine($"Il voto massimo della scuola {scuola.GetNome()} è {votomax.GetVotoDouble()}.");
        }
    }
}
