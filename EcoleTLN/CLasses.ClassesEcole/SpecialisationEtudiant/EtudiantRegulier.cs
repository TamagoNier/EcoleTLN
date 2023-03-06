﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class EtudiantRegulier : Etudiant
    {
        private double noteMoyenne;
        public double NoteMoyenne { get => noteMoyenne; set => noteMoyenne = value; }

        public EtudiantRegulier(int matricule, string nom, int anneeArrive, string section, double noteMoyenne)
            :base( matricule, nom, anneeArrive, section)
        {
            this.NoteMoyenne = noteMoyenne;
        }

        
    }
}
