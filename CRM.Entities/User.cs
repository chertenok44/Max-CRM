using Xtensive.Orm;

namespace CRM.Entities;

[HierarchyRoot]
public class User : Entity
{
    public required long Id { get; set; }

    public required string Name { get; set; }

    internal User(Session session) : base(session) { }
}
