using System;

namespace Shared.Models
{
    public interface ITeaElementBase
    {
        DateTime CreateDate { get; set; }
        Guid Id { get; set; }
        string Name { get; set; }
        string Price { get; set; }
        DateTime UpdateDate { get; set; }
    }
}