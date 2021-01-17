using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class TeaElementBase : ITeaElementBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
