using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class EtudiantEchange : Etudiant
    {
        private string universiteOrigine;
        public string UniversiteOrigine { get => universiteOrigine; set => universiteOrigine = value; }

        public EtudiantEchange(int matricule, string nom, int anneeArrive, string section, string universiteOrigine)
            :base(matricule, nom, anneeArrive, section)
        {
            this.universiteOrigine = universiteOrigine;
        }

        
    }
}
