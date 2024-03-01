using CRM.Services.Contracts;
using Xtensive.Orm;

namespace CRM.Entities.Factory;

public class UserFactory
{
    public User Create(Session session, UserInputDto model) => new User(session) {
        SID = model.Sid,
        Name = model.Name
    };

    public User Update(User entity, UserInputDto model)
    {
        entity.SID = model.Sid;
        entity.Name = model.Name;
        return entity;
    }
}
