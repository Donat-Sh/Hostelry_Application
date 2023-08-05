namespace HostelryWeb.WebModels.RegistrationModels
{
    public class LoginResponseDTO
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
    }
}
