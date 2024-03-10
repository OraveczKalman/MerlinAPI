using MerlinAPI.Models;

namespace MerlinAPI.Requests
{
    public class LoginRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EndPoint { get; set; }
        public string Event { get; set; }
        public string DeviceId { get; set; }
        public string LoginData { get; set; }
    }

    public class UserListRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EndPoint { get; set; }
        public string Event { get; set; }
        public string DeviceId { get; set; }
    }

    public class InsertUserRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DeviceId { get; set; }
        public int UserId { get; set; }
        public User Data { get; set; }
    }
}
