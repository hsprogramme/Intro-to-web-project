namespace Web.Models
{
    public class ErrorViewModel
    {
        public string? hs { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}