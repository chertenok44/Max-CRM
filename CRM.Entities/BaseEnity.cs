#nullable enable
using Xtensive.Orm;

namespace CRM.Entities;

public class BaseEntity : Entity
{
    public required Guid Id { get; set; }

    public required DateTimeOffset CreatedOn { get; set; }
    public required User CreatedBy { get; set; }

    public required DateTimeOffset LastUpdatesAt { get; set; }

    public required User LastUpdatetBy { get; set; }

    internal BaseEntity(Session session):base(session) { }
}
