namespace ScribanEmailTemplateBuilder.Models
{
    public class EmailDataModel
    {
        public List<string> Recipients { get; set; } = [];
        public string Subject { get; set; } = "";
        public string Message { get; set; } = "";
        public DateTime Date { get; set; } = DateTime.Now;
        
        public string CtaLink { get; set; } = "";
        public string CtaText { get; set; } = "";
        public string SenderName { get; set; } = "";
        public string CompanyName { get; set; } = "";
         
        public string UnsubscribeLink { get; set; } = "";
        public string PrivacyPolicyLink { get; set; } = "";
    }
}
