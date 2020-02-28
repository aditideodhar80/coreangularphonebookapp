using System.ComponentModel.DataAnnotations;

namespace CoreAngularDemo.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
