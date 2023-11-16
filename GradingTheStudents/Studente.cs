using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingTheStudents
{
    internal class Studente
    {

        public string? nome {  get; set; }
        public int voto { get; set; }


        public Studente(string? nome, int voto)
        {
            this.nome = nome;
            this.voto = voto;
        }

        public override string ToString()
        {
            return $"{nome}: {voto}";
        }
    }
}
