using System.Threading.Tasks;

namespace CoreAngularDemo.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}