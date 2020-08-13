using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFCodeFirst.Models
{
    public class Inventory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Required]
        public int ID { get; set; }
        [Required]
        public int MaterialID { get; set; }
        [Required]
        public decimal Quantity { get; set; }
        [Required]
        public int Creater { get; set; }
        [DataType(DataType.DateTime), Required]
        public DateTime CreatDate { get; set; }
        [Required]
        public int LastEditor { get; set; }
        [DataType(DataType.DateTime), Required]
        public DateTime LastUpdate { get; set; }
        [ForeignKey("MaterialID")]
        public virtual Material Material { get; set; }
    }
}