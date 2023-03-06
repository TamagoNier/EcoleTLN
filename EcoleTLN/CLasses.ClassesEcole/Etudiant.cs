using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    abstract class Etudiant :Contact
    {
        protected string section;

        protected Etudiant(int matricule, string nom, int anneeArrive, string section):base(matricule, nom, anneeArrive)
        {
            this.Section = section;
        }

        public string Section { get => section; set => section = value; }
    }
}
