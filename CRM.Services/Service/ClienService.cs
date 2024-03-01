using CRM.Entities;

namespace CRM.Services.Service;

public class ClienService
{
    private readonly ISessionProvider sessionProvider;

    public Client Create(string name)
    {
        return new Client(sessionProvider.Get()) {
            Name = name
        };
    }

    public IQueryable<Client> Get()
    {
        return sessionProvider.Get().Query.All<Client>();
    }

    public Client Get(string id)
    {
        return sessionProvider.Get().Query.SingleOrDefault<Client>(id);
    }

    public ClienService(ISessionProvider sessionProvider)
    {
        this.sessionProvider = sessionProvider;
    }
}
