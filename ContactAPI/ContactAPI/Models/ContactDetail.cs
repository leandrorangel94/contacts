using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContactAPI.Models
{
    public class ContactDetail
    {
        [Key]
        public int ContactDetailId { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string Name { get; set; }
        [Column(TypeName = "NVARCHAR(20)")]
        public string Telephone { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string Email { get; set; }
    }
}
