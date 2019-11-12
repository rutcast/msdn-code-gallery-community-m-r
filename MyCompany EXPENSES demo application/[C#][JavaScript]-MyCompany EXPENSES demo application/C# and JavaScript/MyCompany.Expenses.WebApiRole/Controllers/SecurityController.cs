﻿namespace MyCompany.Expenses.WebApiRole.Controllers
{
    using System;
    using System.Configuration;
    using System.IdentityModel.Services;
    using System.IdentityModel.Services.Configuration;
    using System.Web.Http;
    
    /// <summary>
    /// Security Controller
    /// </summary>
    [RoutePrefix("api/security")]
    [Authorize]
    public class SecurityController : ApiController
    {
        /// <summary>
        /// Get logout url.
        /// </summary>
        /// <returns></returns>
        [Route("logoutUrl")]
        [Authorize]
        public string GetLogoutUrl()
        {
            // Load Identity Configuration
            FederationConfiguration config = FederatedAuthentication.FederationConfiguration;

            // Get wtrealm from WsFederationConfiguation Section
            string wtrealm = config.WsFederationConfiguration.Realm;
            string wsFederationEndpoint = ConfigurationManager.AppSettings["ida:Issuer"];

            SignOutRequestMessage signoutRequestMessage = new SignOutRequestMessage(new Uri(wsFederationEndpoint), wtrealm);
            signoutRequestMessage.Parameters.Add("wtrealm", wtrealm);
            FederatedAuthentication.SessionAuthenticationModule.SignOut();

            string signoutUrl = signoutRequestMessage.WriteQueryString();
            return signoutUrl;
        }
    }
}