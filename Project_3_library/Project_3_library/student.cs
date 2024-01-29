using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_library
{
    public class Student : Person
    {
        public string StudentId { get; set; }

        public string GetCellPhoneNumber()
        {
            // Your implementation to get the cell phone number
            // For example, you can return a placeholder value
            return "708-890-5772";
        }
    }
}
