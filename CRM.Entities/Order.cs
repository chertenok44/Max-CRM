using Xtensive.Orm;

namespace CRM.Entities;

[HierarchyRoot]
public class Order : BaseEntity
{
    [Field(Nullable = false)]
    public required Requets Requets { get; set; }

    [Field(Nullable = false )]
    public OrderState State { get; set; }

    internal Order(Session session) : base(session) { }
}
