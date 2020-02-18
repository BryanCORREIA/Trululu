using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trululu.web.Entities;


namespace Trululu.web.Data
{
    public class MockCastingRepository : ICastingRepository
    {
        private List<Casting> _castings = new List<Casting>
        {
            // fausse liste de castings en attendant la 
            // methode de recup des données dans la BDD
            new Casting { Id = 1, Wording = "Radio-Crochet France Bleu", AgeMin = 18, AgeMax = 99, DescriptionPost = "Concours de chant", DescriptionProfile = "Chanteur"},
            new Casting { Id = 2, Wording = "Nouvelle Star", AgeMin = 12, AgeMax = 99, DescriptionPost = "Concours de Talent TV", DescriptionProfile = "Tous types d'artiste"},
            new Casting { Id = 3, Wording = "Koh Lanta", AgeMin = 18, AgeMax = 65, DescriptionPost = "Emission TV - Jeu de survie", DescriptionProfile = "Tous types de profil"},
            new Casting { Id = 4, Wording = "Des Chiffres et des Lettres", AgeMin = 35, AgeMax = 99, DescriptionPost = "Emission TV - Jeu de réflexion", DescriptionProfile = "Tous types de profil"},
            new Casting { Id = 5, Wording = "Photos de mode", AgeMin = 16, AgeMax = 35, DescriptionPost = "Shooting - Catalogue prêt-à-porter", DescriptionProfile = "Féminin"}
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
