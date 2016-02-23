using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Microsoft.WindowsAzure.MobileServices;    // add here

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CloudBread_Dev_Authkey_Gen_win8._1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MobileServiceUser user;

        private async System.Threading.Tasks.Task<bool> AuthenticateAsync()
        {
            
            bool success = false;
            try 
            {
                // Sign-in using Facebook authentication.
                // change property for twitter, google id, microsoft id 
                user = await App.MobileService
                    .LoginAsync(MobileServiceAuthenticationProvider.Facebook);
                txtSID.Text = user.UserId;
                txtAuthKey.Text = user.MobileServiceAuthenticationToken;

                success = true;
            }
            catch (InvalidOperationException)
            {
                throw;
                //string message = "Generate auth key. You must log in";
            }

            return success;
        }

        public MainPage()
        {
            this.InitializeComponent();
        }

        // login button
        private async void btnGen_Click(object sender, RoutedEventArgs e)
        {
            await AuthenticateAsync();
        }
    }
}
