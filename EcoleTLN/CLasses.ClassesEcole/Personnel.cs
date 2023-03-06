﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    abstract class Personnel : Contact
    {
        protected string nomLaboratoire;
        protected double salaire;

        public string NomLaboratoire { get => nomLaboratoire; set => nomLaboratoire = value; }
        public double Salaire { get => salaire; set => salaire = value; }

        protected Personnel(int matricule, string nom, int anneeArrive, string nomLaboratoire, double salaire)
            :base(matricule, nom, anneeArrive)
        {
            this.NomLaboratoire = nomLaboratoire;
            this.Salaire = salaire;
        }
    }
}
