﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jwt.Entity
{
    public class Users : Entity
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual IList<Roles> Role { get; set; }
        public virtual string PassWord { get; set; }
        public virtual bool HasToken { get; set; } 
        public virtual DateTime CreatedAt { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false;
    }
}
