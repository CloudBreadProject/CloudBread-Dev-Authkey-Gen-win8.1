# CloudBread-Dev-Authkey-Gen-win8.1
This porject is authentication provider authkey development &amp; testing project for CloudBread game server engine 

##Installation guide
Fork this project to your repository and open it in Visual Studio 2015. 

Change *app.xaml.cs* file code to your Authenticated Server
```
public static MobileServiceClient MobileService = new MobileServiceClient(
    "https://yourcloudbreadserver.azurewebsites.net/api/ping"
);
```

Change *MainPage.xaml.cs* file property of *MobileServiceAuthenticationProvider* to your authentication setting.
```
user = await App.MobileService
  .LoginAsync(MobileServiceAuthenticationProvider.Facebook);  // change here
```

Build and execute app. Click Generate auth key and logon to authentication provider. 
Now you should copy *auth key* for deveopment purpose and paste the key at Postman request header *x-zumo-auth* value.

For more information, follow up the official project wiki document 
https://github.com/CloudBreadProject/CloudBread/wiki 

License : MIT
