using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Site.Models.Entities;


namespace Site.Models.Entities
{
    [Table("Category", Schema = "dbo")]
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [DataType(DataType.Text), MaxLength(50)]
        public string Name { get; set; }
    }
}
