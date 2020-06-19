using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Andamios.Web.Helpers
{
    //public class RoleClaimsPrincipalFactory : RoleClaimsPrincipalFactory
    //{
    //    public RoleClaimsPrincipalFactory(RoleManager<Role> _roleManager, IOptions<IdentityOptions> optionsAccessor) 
    //        : base(_roleManager, optionsAccessor)
    //    {

    //    }

    //    protected override async Task<ClaimsIdentity> GenerateClaimAsync(Role role)
    //    {
    //        var identity = await base.GenerateClaimAsync(role);
    //        identity.AddClaim(new Claim("ContactName", role. ?? "[Click to edit profile]"));
    //        return identity;
    //    }
    //}
}
