using Classes.ClassesEcole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleTLN
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TesteAjouterContact();

                Console.WriteLine("Fin Normale du Programme");
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        public static void TesteAjouterContact()
        {
            Enseignant contact = new Enseignant(1, "Robert Jaques", 2010, "Labo Sciences", 15000.0, "BAC STL") ;
            Etudiant contactUn = new Etudiant(2, "Robert Morin", 2002, "BTS SIO");
            EtudiantRegulier contactDeux = new EtudiantRegulier(3, "Robert Christophe", 2012, "BTS CG", 12.2);
            EtudiantRegulier contactTrois = new EtudiantRegulier(4, "Robert Christophe Jr", 2017, "BTS CG", 15.5);

            Ecole ecole = new Ecole("La Tessy", 1689);

            ecole.AjouterContact(contact);
            ecole.AjouterContact(contactUn);
            ecole.AjouterContact(contactDeux);
            ecole.AjouterContact(contactTrois);

            Console.WriteLine("Le nombre moyen d'années passé est : " + ecole.AncienneteMoyenne());
            Console.WriteLine("Robert Jacques est étudiant : " + ecole.EstEtudiant(contact));
            Console.WriteLine("Robert Christophe est étudiant : " + ecole.EstEtudiant(contactDeux));
            Console.WriteLine("Le nombre d'etudiants est : "+ ecole.NbEtudiants());
             Console.WriteLine("La moyenne des notes des etudiants reguliers est : " +ecole.MoyenneEtudiantRegulier());
            Console.WriteLine("Matricule 15 est present dans l'ecole : " + ecole.ExisteContact(15));

            Console.WriteLine("Matricule 3 est present dans l'ecole : " + ecole.ExisteContact(3));
            Console.WriteLine("Matricule 2 est present dans l'ecole : " + ecole.ExisteContact(contactUn));
            Console.WriteLine("Matricule 16 est present dans l'ecole : " + ecole.ExisteContact(new Contact(16,"Gilbert", 2015)));

            ecole.AfficherTous();
        }
    }
}
