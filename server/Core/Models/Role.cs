﻿using server.Core.Enums;

namespace server.Core.Models
{
    public class Role
    {
        public int Id { get; set; }

        public RoleType roleType { get; set; }
    }
}
