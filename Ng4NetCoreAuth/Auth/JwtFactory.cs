using Microsoft.Extensions.Options;
using Ng4NetCoreAuth.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Ng4NetCoreAuth.Auth
{
  public class JwtFactory : IJwtFactory
  {
    private readonly JwtIssuerOptions _jwtOptions;

    public JwtFactory(IOptions<JwtIssuerOptions> jwtOptions)
    {
      _jwtOptions = jwtOptions.Value;
      ThrowIfInvalidOptions(_jwtOptions);
    }    

    public ClaimsIdentity GenerateClaimsIdentity(string userName, string id)
    {
      throw new NotImplementedException();
    }

    public async Task<string> GenerateEncodedToken(string userName, ClaimsIdentity identity)
    {
      var claims = new[]
      {
        new Claim(JwtRegisteredClaimNames.Sub, userName),
        new Claim(JwtRegisteredClaimNames.Jti, await _jwtOptions.JtiGenerator()),
        new Claim(JwtRegisteredClaimNames.Iat, ToUnixEpochDate(_jwtOptions.IssuedAt).ToString(), ClaimValueTypes.Integer64),
        identity.FindFirst(Helpers.Constants.Strings.JwtClaimIdentifiers.Rol),

      }
    }

    private object ToUnixEpochDate(DateTime issuedAt)
    {
      throw new NotImplementedException();
    }

    private void ThrowIfInvalidOptions(JwtIssuerOptions jwtOptions)
    {
      throw new NotImplementedException();
    }
  }
}
