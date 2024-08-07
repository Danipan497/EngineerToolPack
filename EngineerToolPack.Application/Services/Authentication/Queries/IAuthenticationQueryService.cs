﻿using EngineerToolPack.Application.Services.Authentication.Common;
using ErrorOr;

namespace EngineerToolPack.Application.Services.Authentication.Queries
{
    public interface IAuthenticationQueryService
    {
        ErrorOr<AuthenticationResult> Login(string email, string password);
    }
}

