#nullable  enable
using Xtensive.Orm;

namespace CRM.Entities;

[HierarchyRoot]

public class Client : BaseEntity
{
    [Field]
    public required string Name { get; set; }
    internal Client(Session session) : base(session) { }
}
