using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    public class Battle
    {
        [Key]
        public int BattleId { get; private set; }

        [ForeignKey("Users")]
        public int UserID { get; set; }

        [ForeignKey("Heroes")]
        public int WinnerID { get; set; }

        [ForeignKey("Heroes")]
        public int LoserID { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        private Battle()
        {

        }

        public Battle(DateTime createdOn)
        {
            CreatedOn = createdOn;
        }
    }
}
