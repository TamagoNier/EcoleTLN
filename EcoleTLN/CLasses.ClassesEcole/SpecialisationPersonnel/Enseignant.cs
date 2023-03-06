using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Enseignant :Personnel
    {
        private string section;
        public string Section { get => section; set => section = value; }

        public Enseignant(int matricule, string nom, int anneeArrive, string nomLaboratoire, double salaire, string section)
            :base(matricule, nom, anneeArrive, nomLaboratoire, salaire)
        {
            this.Section = section;
        }

        
    }
}
