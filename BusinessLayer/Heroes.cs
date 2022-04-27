using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    public class Heroes
    {
        [Key]
        public int HeroId { get;private set; }

        [ForeignKey("Users")]
        public int UserID { get; set; }

        [Required]
        public string CharacterName { get; set; }

        [Required]
        public string CharacterType { get; set; }

        [Required, Range(0.00, double.MaxValue)]
        public decimal AttackPoints { get; set; }

        [Required, Range(0.00, double.MaxValue)]
        public decimal DefensePoints { get; set; }

        [Required, Range(0.00, double.MaxValue)]
        public decimal HealthPoints { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }


        private Heroes()
        {
           
        }

        public Heroes(string characterName, string characterType, decimal attackPoints, decimal defensePoints, decimal healthPoints, DateTime createdOn)
        {
            CharacterName = characterName;
            CharacterType = characterType;
            AttackPoints = attackPoints;
            DefensePoints = defensePoints;
            HealthPoints = healthPoints;
            CreatedOn = createdOn;
        }
    }
}
