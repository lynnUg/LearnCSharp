using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Models
{
    public class Role
      {
             [Key]
             public int Id { get; set; }
             [Required]
             [StringLength(50)]
             public String Name { get; set; }
      }
}
