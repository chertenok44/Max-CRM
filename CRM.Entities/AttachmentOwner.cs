using Xtensive.Orm;

namespace CRM.Entities;

[HierarchyRoot]
public abstract class AttachmentOwner : BaseEntity
{
    [Field]
    public EntitySet<Attachment> Attachments { get; set; }

    internal AttachmentOwner(Session session) : base(session) { }
}
