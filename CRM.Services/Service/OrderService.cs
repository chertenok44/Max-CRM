using CRM.Entities;

namespace CRM.Services;

public class OrderService
{
    private readonly ISessionProvider sessionProvider;

    public Order Create(Request request)
    {
        return new Order(sessionProvider.Get()) {
            Request = request,
            State = OrderState.New
        };
    }

    public IQueryable<Order> Get()
    {
        return sessionProvider.Get().Query.All<Order>();
    }

    public Order Get(string id)
    {
        return sessionProvider.Get().Query.SingleOrDefault<Order>(id);
    }

    public OrderService(ISessionProvider sessionProvider)
    {
        this.sessionProvider = sessionProvider;
    }
}
