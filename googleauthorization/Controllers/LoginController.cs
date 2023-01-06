using Microsoft.AspNetCore.Mvc;
using GoogleAuthentication.Services;

namespace googleauthorization.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // you will recieve the code parameter whenever user logged in by google 
        public async Task<ActionResult> GoogleLoginCallBack(string code)
        {
            var clientId = "164794501167-ct7gf8aioq248nh9c882iks3dp685o9u.apps.googleusercontent.com";
            var url = "https://localhost:7235/Login/GoogleLoginCallback";
            var clientsecret = "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";

            var token = await GoogleAuth.GetAuthAccessToken(code, clientId, clientsecret, url);
            //getting user profile
            var userProfile = await GoogleAuth.GetProfileResponseAsync(token.AccessToken);

            ViewBag.userProfile = userProfile;

            var a=_ = userProfile[0];
            Console.WriteLine(a);
            //userProfile.id;
            //userProfile.email;
            //userProfile.verified_email;
            //userProfile.name;
            //userProfile.given_name;
            //userProfile.family_name;
            //userProfile.picture;
            //userProfile.locale;


            return View();
        }
    }
}
