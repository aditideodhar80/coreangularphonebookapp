using System.Threading.Tasks;
using CoreAngularDemo.Views;
using Xamarin.Forms;

namespace CoreAngularDemo.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
