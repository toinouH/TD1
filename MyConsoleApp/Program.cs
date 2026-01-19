using System;
using System.Collections.Generic;

namespace MyConsoleApp {
    class Program {

        private static void Main(string[] args) {
            AnnuaireService service = new AnnuaireService();
            service.InitListePersonnes();
            AfficherMenu(service);
        }

        private static void AfficherMenu(AnnuaireService service) {
            Console.WriteLine("=== MENU ANNUAIRE ===");
            Console.WriteLine("1. Lister les personnes");
            Console.WriteLine("2. Créer une personne");
            Console.WriteLine("3. Supprimer une personne");
            Console.WriteLine("4. Quitter");

            bool quitter = false;
            while (!quitter) {
                Console.Write("Votre choix (1-4) : ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choix)) {
                    Console.WriteLine("Entrée invalide. Veuillez saisir un nombre entre 1 et 4.");
                    Console.WriteLine("Appuyez sur Entrée pour continuer...");
                    Console.WriteLine("Appuyer sur une touche et effacer la console après :)");
                    Console.ReadLine();
                    continue;
                }

                switch (choix) {
                    case 1:
                        ListerPersonnes(service);
                        break;
                    case 2:
                        CreerPersonne(service);
                        break;
                    case 3:
                        SupprimerPersonne(service);
                        break;
                    case 4:
                        quitter = true;
                        break;
                    default:
                        Console.WriteLine("Choix inconnu. Veuillez sélectionner une option entre 1 et 4.");
                        break;
                }

                if (!quitter) {
                    Console.WriteLine();
                    Console.WriteLine("Appuyez sur Entrée pour revenir au menu...");
                    Console.ReadLine();
                }
            }
        }

        private static void ListerPersonnes(AnnuaireService service) {
            List<Personne> listPersonne = service.GetListePersonnes();
            if (listPersonne.Count == 0) {
                Console.WriteLine("Aucune personne dans l'annuaire. Merci d'en insérer");
            }
            else {
                listPersonne.ForEach(personne => Console.WriteLine(personne));
            }
            AfficherMenu(service);
        }

        private static void CreerPersonne(AnnuaireService service) {
            
            // La gestion de la nullité n'est pas implémenté : pas bien !
            Console.WriteLine("Veuillez saisir les informations de la personne à créer :");
            
            Console.WriteLine("Entrez la civilité");
            string civilite = Console.ReadLine();
            
            Console.WriteLine("Entrez le nom");
            string nom = Console.ReadLine();
            
            Console.WriteLine("Entrez le prénom");
            string prenom = Console.ReadLine();
            
            Console.WriteLine("Entrez la date de naissance au format jj/mm/aaaa");
            string dateNaissance = Console.ReadLine();
            
            Console.WriteLine("Entrez la ville");
            string ville = Console.ReadLine();
            
            Console.WriteLine("Entrez le code postal");
            string codePostal = Console.ReadLine();
            
            Console.WriteLine("Entrez le nom de la rue");
            string nomRue = Console.ReadLine();
            
            Console.WriteLine("Entrez le numéro de la rue");
            string numeroRue = Console.ReadLine();
            
            Console.WriteLine("Entrez le numéro de téléphone");
            string numeroTelephone = Console.ReadLine();
            
            Personne personne = new() {
                Civilite = civilite,
                Nom = nom,
                Prenom = prenom,
                DateNaissance = DateOnly.Parse(dateNaissance),
                Ville = ville,
                CodePostal = int.Parse(codePostal),
                NomRue = nomRue,
                NumeroRue = int.Parse(numeroRue),
                NumeroTelephone = int.Parse(numeroTelephone)
            };

            service.CreationPersonne(personne);
            
            Console.WriteLine("La personne a été créée avec succès.");
            AfficherMenu(service);
        }

        private static void SupprimerPersonne(AnnuaireService service) {
            
            List<Personne> listPersonne = service.GetListePersonnes();
            if (listPersonne.Count == 0) {
                Console.WriteLine("Aucune personne dans l'annuaire. Merci d'en insérer vous allez être redirigé vers la création de personne");
                CreerPersonne(service);
                return;
            }

            // Afficher la liste numérotée
            for (int i = 0; i < listPersonne.Count; i++) {
                Personne p = listPersonne[i];
                Console.WriteLine($"{i + 1}. {p.Civilite} {p.Prenom} {p.Nom} - {p.Ville}"); 
            }

            Console.Write("Entrez le numéro de la personne à supprimer : ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int numero) || numero < 1 || numero > listPersonne.Count) {
                Console.WriteLine("Numéro invalide.");
                AfficherMenu(service);
                return;
            }

            int index = numero - 1;
            Personne personneASupprimer = listPersonne[index];
            service.SuppressionPersonne(personneASupprimer);
            Console.WriteLine($"Personne supprimée : {personneASupprimer.Prenom} {personneASupprimer.Nom}");
            AfficherMenu(service);
        }
    }
}