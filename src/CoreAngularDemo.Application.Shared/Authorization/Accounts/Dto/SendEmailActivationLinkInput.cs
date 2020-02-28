using System.ComponentModel.DataAnnotations;

namespace CoreAngularDemo.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}