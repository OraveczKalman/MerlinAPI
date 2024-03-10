namespace MerlinAPI.Responses
{
    public class LoginResponse
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public long UserId { get; set; }
        public long? UserGroup { get; set; }
        public string Language { get; set; }
    }
}
