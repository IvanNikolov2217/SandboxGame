using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    public class Roles
    {
        [Key]
        public int RoleId { get; private set; }

        [Required,MaxLength(50)]
        public string RoleName { get; set; }

        private Roles()
        {

        }

        public Roles(string roleName)
        {
            RoleName = roleName;
        }
    }
}
