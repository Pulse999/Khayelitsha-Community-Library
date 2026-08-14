using System;
using System.Collections.Generic;
using System.Text;

namespace KhayelitshaLibrary.WinForms.Models
{
    public class Loan
    {
        public int LoanID { get; set; }

        public int MemberID { get; set; }

        public int CopyID { get; set; }

        public int StaffID { get; set; }

        public DateOnly LoanDate { get; set; }

        public DateOnly DueDate { get; set; }

        public DateOnly? ReturnDate { get; set; }
    }
}
