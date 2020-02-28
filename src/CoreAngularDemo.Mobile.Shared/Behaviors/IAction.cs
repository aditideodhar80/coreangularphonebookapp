using Xamarin.Forms.Internals;

namespace CoreAngularDemo.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}