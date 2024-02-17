using Xtensive.Orm;

namespace CRM.Entities;

[HierarchyRoot]
public class User : Entity
{
    [Field]
    public required long Id { get; set; }

    [Field]
    public required string Name { get; set; }

    internal User(Session session) : base(session) { }
}
