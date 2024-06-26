﻿using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Logger.ToSeq.API.Services;

public class JwtProvider
{
    public string CreateToken()
    {
        List<Claim> claims = new()
        {
            new Claim("UserId", "78e1929e-2029-4df5-a354-d1202fd8bc61"),
            new Claim(ClaimTypes.NameIdentifier, "CumaKose")
        };

        DateTime expires = DateTime.Now.AddDays(1);

        JwtSecurityToken jwtSecurityToken = new(
           issuer: "Cuma",
           audience: "localhost",
           claims: claims,
           expires: expires,
           signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("My secret key My secret key My secret key My secret key My secret key")), SecurityAlgorithms.HmacSha512));

        JwtSecurityTokenHandler handler = new();

        var token = handler.WriteToken(jwtSecurityToken);

        return token;
    }
}
