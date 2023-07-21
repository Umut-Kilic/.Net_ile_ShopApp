﻿using Microsoft.AspNetCore.Identity;

namespace Goksell_WebApp.Identity
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
