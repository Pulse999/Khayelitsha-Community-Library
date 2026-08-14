using System;
using System.Collections.Generic;
using System.Text;

namespace KhayelitshaLibrary.WinForms.Models
{
    public class BookCopy
    {
        public int CopyID { get; set; }

        public int BookTitleID { get; set; }

        public string Status { get; set; } = string.Empty;
    }
}
