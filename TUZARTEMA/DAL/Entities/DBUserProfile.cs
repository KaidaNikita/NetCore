using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TUZARTEMA.DAL.Entities
{
    public class DBUserProfile
    {
        [Key,ForeignKey("User")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date_of_Birth { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }
        public DBCity City { get; set; }
        public DbUser User { get; set; }
    }
}
