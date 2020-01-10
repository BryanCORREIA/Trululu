using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trululu.web.Entities;


namespace Trululu.web.Data
{
    public class MockCastingRepository
    {
        private List<Casting> _castings = new List<Casting>
        {
            // fausse liste de castings en attendant la 
            // methode de recup des données dans la BDD
            new Casting { Id = 1, Libelle = "Radio-Crochet France Bleu", AgeMin = 18, AgeMax = 99, DescriptionPoste = "Concours de chant", DescriptionProfil = "Chanteur"},
            new Casting { Id = 2, Libelle = "Nouvelle Star", AgeMin = 12, AgeMax = 99, DescriptionPoste = "Concours de Talent TV", DescriptionProfil = "Tous types d'artiste"},
            new Casting { Id = 3, Libelle = "Koh Lanta", AgeMin = 18, AgeMax = 65, DescriptionPoste = "Emission TV - Jeu de survie", DescriptionProfil = "Tous types de profil"},
            new Casting { Id = 4, Libelle = "Des Chiffres et des Lettres", AgeMin = 35, AgeMax = 99, DescriptionPoste = "Emission TV - Jeu de réflexion", DescriptionProfil = "Tous types de profil"},
            new Casting { Id = 5, Libelle = "Photos de mode", AgeMin = 16, AgeMax = 35, DescriptionPoste = "Shooting - Catalogue prêt-à-porter", DescriptionProfil = "Féminin"}
        };

        public IEnumerable<Casting> GetAllCastings()
        {
            return _castings;
        }

        public Casting GetCastingById(int castingId)
        {
            return _castings.FirstOrDefault(c => c.Id == castingId);
        }
    }
}
