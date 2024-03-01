using Xtensive.Orm;

namespace CRM.Entities;

[HierarchyRoot]
public class Order : BaseEntity
{
    [Field(Nullable = false)]
    public required Request Request { get; set; }

    [Field(Nullable = false )]
    public required OrderState State { get; set; }

    public Order(Session session) : base(session) { }
}
