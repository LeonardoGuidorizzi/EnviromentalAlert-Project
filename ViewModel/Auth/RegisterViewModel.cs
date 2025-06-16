﻿using Fiap.Api.EnvironmentalAlert.Enums;

namespace Fiap.Api.EnvironmentalAlert.ViewModel.Auth
{
    public class RegisterViewModel
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Role { get; set; }
    }
}
