﻿namespace T_1.Entities
{
    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Role> Roles { get; set; }

    }
}