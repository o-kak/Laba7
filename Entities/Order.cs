namespace Entities
{
    public enum OrderTypes
    {
        TakeOut,
        Delivery
    }

    public enum OrderStates
    {
        Created,
        Processing,
        AlmostReady,
        Ready,
        Given,
        Closed
    }
    public class Order : IDomainObject
    {
        public string ID { get; set; }
        public OrderTypes Type { get; set; }
        public string WaiterID { get; set; }
        public OrderStates State { get; set; }
        public bool IsPaidFor { get; set; }
    }
}
