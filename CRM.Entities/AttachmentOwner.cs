#nullable enable
using Xtensive.Orm;

namespace CRM.Entities;

public abstract class AttachmentOwner : BaseEntity
{
    [Field]
    public EntitySet<Attachment> Attachments { get; set; }

    internal AttachmentOwner(Session session) : base(session) { }
}
