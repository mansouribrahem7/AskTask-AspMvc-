using System.ComponentModel.DataAnnotations;

namespace Final_Project.ViewModel
{
    public class LoginViewModel
    {
      
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
