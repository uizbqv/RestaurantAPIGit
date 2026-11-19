namespace RestaurantAPI.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int GuestCount { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime? PaidAt { get; set; }
        public double TotalPrice { get; set; }

    }
}
