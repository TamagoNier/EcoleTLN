using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Contact
    {
        protected int matricule;
        protected string nom;
        protected int anneeArrive;

        public int Matricule { get => matricule; private set => matricule = value; }
        public string Nom { get => nom; set => nom = value; }
        public int AnneeArrive
        {
            get => anneeArrive;
            set
            {
                if (value > DateTime.Now.Year)
                {
                    throw new Exception("Format date non valide");
                }
                else
                {
                    anneeArrive = value;
                }
            }
        }

        public Contact(int matricule, string nom, int anneeArrive)
        {
            this.Matricule = matricule;
            this.Nom = nom;
            this.AnneeArrive = anneeArrive;
        }

        public override string ToString() 
        {
            return this.GetType().Name + " :" +"\n\tMatricule : " + this.matricule + "\n\tNom : " + 
                this.nom + "\n\tAnnée : " + this.anneeArrive;
        }
    }


}
