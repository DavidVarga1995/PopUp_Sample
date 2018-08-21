using Android.App;
using Android.Support.Design.Widget;
using Android.Widget;
using Plugin.CurrentActivity;
using PopUp.DSInterfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(PopUp.Droid.AndroidPopUp))]
namespace PopUp.Droid
{
    public class AndroidPopUp : IAndroidPopUp
    {
        public void ShowSnackbar(string message)
        {
            Activity activity = CrossCurrentActivity.Current.Activity;
            Android.Views.View activityRootView = activity.FindViewById(Android.Resource.Id.Content);
            Snackbar.Make(activityRootView, message, Snackbar.LengthLong).Show();
        }

        public void ShowToast(string message)
        {
            Activity activity = CrossCurrentActivity.Current.Activity;
            Toast.MakeText(activity, message, ToastLength.Long).Show();
        }
    }
}