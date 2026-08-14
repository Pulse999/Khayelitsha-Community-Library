using System;
using System.Collections.Generic;
using System.Text;

namespace KhayelitshaLibrary.WinForms.Models
{
    public class BookTitle
    {
        public int BookTitleID { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public string ISBN { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;
    }
}   

