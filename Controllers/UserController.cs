using MerlinAPI.CoreClasses;
using MerlinAPI.DataClasses;
using MerlinAPI.Models;
using MerlinAPI.Requests;
using MerlinAPI.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Newtonsoft.Json;

namespace MerlinAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private SHA256Class crypt;
        private UserDataClass userDataClass = new();

        public UserController() 
        {
            crypt = new SHA256Class(ApiData.CryptPass);
        }
        
        [HttpPost("Login")]
        public IActionResult Login([FromForm] string content)
        {
            try
            {
                string retVal = "";
                LoginRequest loginRequest = JsonConvert.DeserializeObject<LoginRequest>(crypt.DecryptString(content));
                Debug.WriteLine(loginRequest.DeviceId);
                LoginData loginData = JsonConvert.DeserializeObject<LoginData>(loginRequest.LoginData);
                Debug.WriteLine(loginRequest.LoginData);
                User user = userDataClass.Login(loginData.UserName, loginData.Password);
                if (user != null)
                {
                    LoginResponse loginResponse = new LoginResponse
                    {
                        Name = user.Name,
                        UserName = user.UserName,
                        UserId = (long)user.UserId,
                        UserGroup = user.RightId,
                        Language = ""
                    };
                    retVal = crypt.EncryptString(JsonConvert.SerializeObject(loginResponse));
                    return Ok(retVal);
                }
                else
                {
                    return Unauthorized();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + " " + ex.StackTrace);
                return StatusCode(500);
            }
        }

        [HttpPost("GetUserList")]
        public IActionResult GetUserList([FromForm] string content)
        {
            try
            {
                string retVal = "";
                string requestDecoded = crypt.DecryptString(content);
                retVal = crypt.EncryptString(JsonConvert.SerializeObject(userDataClass.GetAll()));
                return Ok(retVal);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + " " + ex.StackTrace);
                return StatusCode(500);
            }
        }
        
        [HttpPost("InsertUser")]
        public IActionResult InsertUser([FromForm] string content)
        {
            try
            {
                string retVal = "";
                string requestDecoded = crypt.DecryptString(content);
                User user = JsonConvert.DeserializeObject<InsertUserRequest>(requestDecoded).Data;
                retVal = crypt.EncryptString(JsonConvert.SerializeObject(userDataClass.Insert(user)));
                return Ok(retVal);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + " " + ex.StackTrace);
                return StatusCode(500);
            }
        }

        [HttpPost("UpdateUser")]
        public IActionResult UpdateUser([FromForm] string content)
        {
            try
            {
                string retVal = "";
                string requestDecoded = crypt.DecryptString(content);
                User user = JsonConvert.DeserializeObject<InsertUserRequest>(requestDecoded).Data;
                retVal = crypt.EncryptString(JsonConvert.SerializeObject(userDataClass.Update(user)));
                return Ok(retVal);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + " " + ex.StackTrace);
                return StatusCode(500);
            }
        }

        [HttpPost("DeleteUser")]
        public IActionResult DeleteUser([FromForm] string content)
        {
            try
            {
                string retVal = "";
                string requestDecoded = crypt.DecryptString(content);
                User user = JsonConvert.DeserializeObject<InsertUserRequest>(requestDecoded).Data;
                retVal = crypt.EncryptString(JsonConvert.SerializeObject(userDataClass.Delete(user)));
                return Ok(retVal);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + " " + ex.StackTrace);
                return StatusCode(500);
            }
        }
    }
}
