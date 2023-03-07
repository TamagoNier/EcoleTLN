using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Etudiant :Contact
    {
        protected string section;

        public Etudiant(int matricule, string nom, int anneeArrive, string section):base(matricule, nom, anneeArrive)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.AnneeArrive = anneeArrive;

            this.Section = section;
        }

        public string Section { get => section; set => section = value; }

        public override string ToString()
        {
            return base.ToString() + "\n\tSection : " + this.section;
        }
    }
}
