#nullable enable
using Xtensive.Orm;

namespace CRM.Entities;

[HierarchyRoot]
public class Attachment : BaseEntity
{
    [Field(Nullable = false)]
    public required AttachmentOwner Owner { get; set; }

    [Field(Nullable = false)]
    public required string Name { get; set; }

    [Field(Nullable = false)]
    public byte[] Body { get; set; }

    internal Attachment(AttachmentOwner owner, string name, byte[] body, Session session) : base(session)
    {
        Owner = owner;
        Name = name;
        Body = body;
    }
}
