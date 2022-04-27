using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    public class Users
    {
        [Key]
        public int UserId { get; private set; }

        [Required,MaxLength(30)]
        public string UserName { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [ForeignKey("Roles")]
        public int RoleId { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        private Users()
        {

        }

        public Users(string userName, string passwordHash, DateTime createdOn)
        {
            UserName = userName;
            PasswordHash = passwordHash;
            CreatedOn = createdOn;
        }
    }
}
