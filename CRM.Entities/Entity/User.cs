using Xtensive.Orm;

namespace CRM.Entities;

[HierarchyRoot]
public class User : Entity
{
    [Field]
    public string SID { get; set; }

    [Field]
    public string Name { get; set; }

    public User(Session session) : base(session) { }
}
