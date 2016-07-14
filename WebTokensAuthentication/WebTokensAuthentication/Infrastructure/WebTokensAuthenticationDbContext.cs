using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTokensAuthentication.Models;

namespace WebTokensAuthentication.Infrastructure
{
    public class WebTokensAuthenticationDbContext : IdentityDbContext<ApplicationUser>
    {
        public WebTokensAuthenticationDbContext()
            : base("WebTokensAuthenticationDbContext", throwIfV1Schema: false)
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public static WebTokensAuthenticationDbContext Create()
        {
            return new WebTokensAuthenticationDbContext();
        }
    }
}