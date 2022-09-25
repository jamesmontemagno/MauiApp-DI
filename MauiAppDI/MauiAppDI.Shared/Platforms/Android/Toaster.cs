using Android.Widget;
using MauiAppDI.Helpers;

namespace MauiAppDI.PlatformImplementations;

public class Toaster : IToast
{
    public void MakeToast(string message)
    {
        Toast.MakeText(Platform.CurrentActivity, "Internet I have!", ToastLength.Long).Show();

    }
}
