using System;
namespace Trululu.web.Entities
{
    public class Utilisateur
    {
        public int id { get; set; }

        public string prenom { get; set; }

        public string nom { get; set; }

        public string email { get; set; }

        public string telephone { get; set; }

        public DateTime dateDeNaissance { get; set; }

        public string motDePasse { get; set; }

        public string role { get; set; }

        public string adresse { get; set; }

        public Utilisateur()
        {
        }
    }
}
