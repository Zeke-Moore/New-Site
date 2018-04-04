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
    public class User : Entity
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
