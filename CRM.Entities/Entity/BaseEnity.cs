using Xtensive.Orm;

namespace CRM.Entities;

public abstract class BaseEntity : Entity
{
    [Key, Field]
    public Guid Id { get; set; }

    [Field]
    public DateTimeOffset CreatedOn { get; set; }

    [Field]
    public string CreatedBy { get; set; }

    [Field]
    public DateTimeOffset LastUpdateAt { get; set; }

    [Field]
    public string LastUpdatetBy { get; set; }

    internal BaseEntity(Session session) : base(session) { }
}
