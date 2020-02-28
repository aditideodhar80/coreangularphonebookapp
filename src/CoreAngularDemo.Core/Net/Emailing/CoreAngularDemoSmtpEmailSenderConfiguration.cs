using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace CoreAngularDemo.Net.Emailing
{
    public class CoreAngularDemoSmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public CoreAngularDemoSmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}