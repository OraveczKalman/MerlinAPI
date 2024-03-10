namespace MerlinAPI.Models.ResponseClasses
{
    public class AuthenticatedUser
    {
        public string Name { get; set; }
        public string Language { get; set; }
        public int UserId { get; set; }
        public int UserGroup { get; set; }
    }
}
