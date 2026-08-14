using System;
using System.Collections.Generic;
using System.Text;

namespace KhayelitshaLibrary.WinForms.Models
{
    public class Member
    {
        public int MemberID { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public int Age { get; set; }


        public string Address { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public DateOnly JoinDate { get; set; }
    }
}