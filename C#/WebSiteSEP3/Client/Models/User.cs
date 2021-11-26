﻿using System.Text.Json.Serialization;

namespace Client.Models
{
    public class User
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("username")] public string Username { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
        [JsonPropertyName("photo")]
        public string Photo { get; set; }
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }
        [JsonPropertyName("securityLevel")]
        public string SecurityLevel { get; set; }
        [JsonPropertyName("role")]
        public string Role { get; set; }
    }
}