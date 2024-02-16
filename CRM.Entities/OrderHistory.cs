using Xtensive.Orm;

namespace CRM.Entities
{
    [HierarchyRoot]
    public class OrderHistory : BaseEntity
    {
        [Field]
        public required OrderState PrevState { get; set; }

        [Field]
        public required  OrderState CurrentState { get; set; }

        public OrderHistory(OrderState prevState, OrderState currentState, Session session) : base(session)
        {
            PrevState = prevState;
            CurrentState = currentState;
        }
    }
}
