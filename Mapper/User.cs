﻿namespace Mapper;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string PasswordHash { get; set; }
    public string Salt { get; set; }
    public string RefreshToken { get; set; }
}