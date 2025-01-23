namespace BT_User
{
    public class OidcSettings
    {
        public string Authority { get; set; } = "https://localhost:7192";
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
