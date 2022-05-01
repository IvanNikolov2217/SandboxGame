using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    public class Rounds
    {
        [Key]
        public int RoundId { get; private set; }

        [ForeignKey("Battle")]
        public int BattleID { get; set; }

        [Required]
        public decimal CharacterOneState { get; set; }
        
        [Required]
        public decimal CharacterTwoState { get; set; }

        [Required]
        public int RoundIndex { get; set; } 

        [Required,Range(1,6)]
        public int DiceResult { get; set; }

        [Required]
        public DateTime CreatedOn  { get; set; }

        private Rounds()
        {

        }

        public Rounds(decimal characterOneState, decimal characterTwoState, int roundIndex, int diceResult)
        {
            CharacterOneState = characterOneState;
            CharacterTwoState = characterTwoState;
            RoundIndex = roundIndex;
            DiceResult = diceResult;
        }
    }
}
