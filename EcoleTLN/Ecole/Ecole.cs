using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Ecole
    {
        private string nom;
        private int anneeCreation;
        private Dictionary< int, Contact> contacts; //int est Contact.Matricule
        
        public string Nom { get => nom; set => nom = value; }
        public int AnneeCreation { get => anneeCreation; set => anneeCreation = value; }
        internal Dictionary<int, Contact> Contacts { get => contacts; set => contacts = value; }

        public Ecole(string nom, int anneeCreation)
        { 
            this.Nom = nom;
            this.AnneeCreation = anneeCreation;
            this.Contacts = new Dictionary<int, Contact>();
        }

        public void AjouterContact(Contact contact)
        {
            this.contacts.Add(contact.Matricule, contact);
        }

        public void AjouterContact(Dictionary<int, Contact> dico)
        {
            foreach (int key in dico.Keys)
            {
                this.contacts.Add(key, dico[key]);
            }
        }

        public void AfficherTous()
        {
            foreach (int i in this.contacts.Keys)
            {
                Console.WriteLine("-----Affiche Tous-----");
                Console.WriteLine(this.contacts[i].ToString());
            }
        }

        public int NbContacts()
        {
            int i = 0;
            foreach(int c in this.contacts.Keys)
            {
                i += 1;
            }
            return i;
        }

        public int NbEtudiants()
        {
            int i = 0;
            foreach (int c in this.contacts.Keys)
            {
                if(this.contacts[c] is Etudiant)
                {
                    i += 1;
                }
            }
            return i;
        }

        public int AncienneteMoyenne()
        {
            int somme = 0;
            int cpt = 0;
            foreach(int i in this.contacts.Keys)
            {
                somme += (DateTime.Now.Year - this.contacts[i].AnneeArrive);
                cpt += 1;
            }

            return somme / cpt;
        }

        public bool EstEtudiant(Contact contact)
        {
            if (this.ExisteContact(contact)) 
            { 
            return contact is Etudiant;
            }else
            {
                throw new Exception("Le contacte n'existe pas");
            }
        }

        public double MoyenneEtudiantRegulier()
        {
            double sommeMoyenne = 0;
            int cpt = 0;
            foreach(Contact i in this.contacts.Values)
            {
                if(i is EtudiantRegulier)
                {
                    EtudiantRegulier e = (EtudiantRegulier)i;
                    sommeMoyenne += e.NoteMoyenne;
                    cpt += 1;
                }
            }
            return sommeMoyenne/cpt;
        }

        public bool ExisteContact(int matricule)
        {
            foreach (int c in this.contacts.Keys)
            {
                if (this.contacts[c].Matricule == matricule)
                {
                    return true;
                }
            }
            return false;
        }
        public bool ExisteContact(Contact contact)
        {
            foreach (Contact c in this.contacts.Values)
            {
                if (c == contact)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
