using Xtensive.Orm;

namespace CRM.Entities
{
    public interface ISessionProvider
    {
        Session Get();
    }
}
