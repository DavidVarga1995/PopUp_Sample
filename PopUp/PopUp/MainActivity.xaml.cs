using PopUp.DSInterfaces;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainActivity : ContentPage
	{
		public MainActivity ()
		{
			InitializeComponent ();

            Content = mainContent;
        }

        void OnToastButtonClicked(object sender, EventArgs args)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                DependencyService.Get<IAndroidPopUp>().ShowToast("This is a toast");
            }
        }

        void OnSnackbarButtonClicked(object sender, EventArgs args)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                DependencyService.Get<IAndroidPopUp>().ShowSnackbar("This is a snackbar");
            }
        }

    }
}