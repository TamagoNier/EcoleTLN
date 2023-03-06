using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Secretaire:Personnel
    {
        public Secretaire(int matricule, string nom, int anneeArrive, string nomLaboratoire, double salaire)
            :base(matricule, nom, anneeArrive, nomLaboratoire, salaire)
        {

        }
    }
}
