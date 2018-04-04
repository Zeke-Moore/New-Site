using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Site.EF;
using Site.Models.Entities;

namespace Site.Models.Entities
{
    public class Notes : Entity
    {
        public string Title { get; set; }
        public string Note { get; set; }
        public string CategoryId { get; set; }
        public string IsDeleted { get; set; }
        public int UserID { get; set; }
    }
}
