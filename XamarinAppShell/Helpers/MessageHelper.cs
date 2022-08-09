using Android.Widget;
using Microsoft.Maui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System.Runtime.InteropServices;

namespace XamarinAppShell.Helpers
{
    public class MessageHelper
    {
        public async Task GenerateToast(string message, [Optional] ToastDuration duration, [Optional] double textSize)
        {
            var toast = CommunityToolkit.Maui.Alerts.Toast.Make(message);
            await toast.Show();
        }
    }
}
