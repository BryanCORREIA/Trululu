using System;
namespace Trululu.web.Entities
{
    public class Utilisateur
    {
        public int Id { get; set; }

        public string FisrtName { get; set; }

        public string Name { get; set; }

        public string Mail { get; set; }

        public string Phone { get; set; }

        public DateTime DateOfBirth { get; set; }
        
        public string Password { get; set; }

        public string Role { get; set; }

        public string Adress { get; set; }

        public Utilisateur()
        {
        }
    }
}
