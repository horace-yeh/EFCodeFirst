using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Model.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Required]
        public int ID { get; set; }
        [Column(TypeName = "NVARCHAR"), Required, MaxLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR"),MaxLength(250),Required]
        public string Account { get; set; }
        [Column(TypeName = "VARCHAR"), MaxLength(250), Required]
        public string Password { get; set; }
        [Required]
        public int Creater { get; set; }
        [DataType(DataType.DateTime), Required]
        public DateTime CreatDate { get; set; }
        [Required]
        public int LastEditor { get; set; }
        [DataType(DataType.DateTime), Required]
        public DateTime LastUpdate { get; set; }
    }
}
