using System.ComponentModel.DataAnnotations;

namespace H2020.IPMDecisions.IDP.Core.Models
{
    public class RegistrationEmail : Email
    {
        [Required]
        public string ConfirmEmailUrl { get; set; }
    }
}