using System;
namespace Trululu.web.Entities
{
    public class Utilisateur
    {
        public int Id { get; set; }

        public string Prenom { get; set; }

        public string Nom { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public DateTime DateDeNaissance { get; set; }
        
        public string MotDePasse { get; set; }

        public string Role { get; set; }

        public string Adresse { get; set; }

        public Utilisateur()
        {
        }
    }
}
