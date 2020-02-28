using System.Threading.Tasks;

namespace CoreAngularDemo.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}