using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Entities.Entities
{
    [Table("User")]
    public class User : Base
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        public string First_Name { get; set; }
        [Column("last_name")]
        public string Last_Name { get; set; }
        [Column("emailaddress")]
        public string EmailAddress { get; set; }
        [Column("password")]

        public string Password { get; set; }
        [Column("phonenumber")]

        public string PhoneNumber { get; set; }
        [Column("usertype")]

        public string UserType { get; set; }
        [Column("userimage")]

        public string UserImage { get; set; } = string.Empty;
        


    }
}
