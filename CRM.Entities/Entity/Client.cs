using Xtensive.Orm;

namespace CRM.Entities;

[HierarchyRoot]
[Index(nameof(Name))]
public class Client : BaseEntity
{
    [Field(Nullable = false)]
    public required string Name { get; set; }

    public Client(Session session) : base(session) { }
}
