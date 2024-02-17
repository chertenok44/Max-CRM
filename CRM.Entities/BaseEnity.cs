using Xtensive.Orm;

namespace CRM.Entities;

public abstract class BaseEntity : Entity
{
    [Field]
    public Guid Id { get; set; }

    [Field]
    public DateTimeOffset CreatedOn { get; set; }

    [Field]
    public User CreatedBy { get; set; }

    [Field]
    public DateTimeOffset LastUpdatesAt { get; set; }

    [Field]
    public User LastUpdatetBy { get; set; }

    internal BaseEntity(Session session) : base(session) { }
}
