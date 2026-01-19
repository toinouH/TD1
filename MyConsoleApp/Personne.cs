using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleApp {

    internal class Personne {
        // Champs privés
        private string _civilite;
        private string _nom;
        private string _prenom;
        private DateOnly _dateNaissance;
        private string _ville;
        private int _codePostal;
        private string _nomRue;
        private int _numeroRue;
        private int _numeroTelephone;

        // Getters / Setters publics
        public string Civilite {
            get { return _civilite; }
            set { _civilite = value; }
        }

        public string Nom {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Prenom {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public DateOnly DateNaissance {
            get { return _dateNaissance; }
            set { _dateNaissance = value; }
        }

        public string Ville {
            get { return _ville; }
            set { _ville = value; }
        }

        public int CodePostal {
            get { return _codePostal; }
            set { _codePostal = value; }
        }

        public string NomRue {
            get { return _nomRue; }
            set { _nomRue = value; }
        }

        public int NumeroRue {
            get { return _numeroRue; }
            set { _numeroRue = value; }
        }

        public int NumeroTelephone {
            get { return _numeroTelephone; }
            set { _numeroTelephone = value; }
        }
    }
}
