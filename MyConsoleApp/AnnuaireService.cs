using System;
using System.Collections.Generic;

namespace MyConsoleApp
{
    internal class AnnuaireService {
        // Liste privée de personnes
        private List<Personne> _listePersonnes = new List<Personne>();

        // Méthode d'initialisation
        public List<Personne> InitListePersonnes() {
            // réinitialiser la liste
            _listePersonnes.Clear();

            Personne p1 = new() {
                Civilite = "M.",
                Nom = "Dupont",
                Prenom = "Jean",
                DateNaissance = new DateOnly(1980, 5, 12),
                Ville = "Paris",
                CodePostal = 75001,
                NomRue = "Rue de Rivoli",
                NumeroRue = 10,
                NumeroTelephone = 612345678
            };

            Personne p2 = new() {
                Civilite = "Mme",
                Nom = "Martin",
                Prenom = "Sophie",
                DateNaissance = new DateOnly(1990, 9, 3),
                Ville = "Lyon",
                CodePostal = 69002,
                NomRue = "Rue de la République",
                NumeroRue = 20,
                NumeroTelephone = 698765432
            };

            _listePersonnes.Add(p1);
            _listePersonnes.Add(p2);

            return _listePersonnes;
        }

        // Méthode GetListePersonnes
        public List<Personne> GetListePersonnes() {
            return _listePersonnes;
        }

        // Méthode CreationPersonne
        public void CreationPersonne(Personne personne)
        {
            if (personne == null) { return;}    // Ne devrait pas se produire
            _listePersonnes.Add(personne);
        }

        // Méthode SuppressionPersonne
        public void SuppressionPersonne(Personne personne) {
            if (personne == null) return;
            _listePersonnes.Remove(personne);
        }
    }
}
