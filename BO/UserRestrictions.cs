﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BO
{
    public partial class UserRestrictions
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int? RestrictionId { get; set; }

        public virtual Restrictions Restriction { get; set; }
        public virtual Users User { get; set; }
    }
}