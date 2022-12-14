// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BO
{
    public partial class Users
    {
        public Users()
        {
            UserPermissions = new HashSet<UserPermissions>();
            UserRestrictions = new HashSet<UserRestrictions>();
        }

        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int LicenseTypeId { get; set; }
        public string PeopleId { get; set; }
        public bool Enabled { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual People People { get; set; }
        public virtual ICollection<UserPermissions> UserPermissions { get; set; }
        public virtual ICollection<UserRestrictions> UserRestrictions { get; set; }
    }
}