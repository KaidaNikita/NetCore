using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace TUZARTEMA.DAL.Entities
{
    public class DBCity
    {
        [Key]
        public string Id { get; set; }
        [Required,StringLength(100)]
        public string Name { get; set; }
    }
}
