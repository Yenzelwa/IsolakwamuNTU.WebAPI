namespace IsolakwamuNTU.WebAPI.Model
{
    public class UserProfile
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public SubscriptionPlan Plan { get; set; }
        public string? Status { get; set; }
    }
}
