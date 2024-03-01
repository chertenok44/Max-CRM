using Xtensive.Orm;

namespace CRM.Entities;

[HierarchyRoot]
public class Request : BaseEntity
{
    [Field(Nullable = false)]
    public required Client Client { get; set; }

    [Field]
    [Association(PairTo = nameof(Attachment.Owner), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
    public EntitySet<Attachment> Attachments { get; set; }

    internal Request(Client client, Session session) : base(session)
    {
        Client = client;
    }
}
