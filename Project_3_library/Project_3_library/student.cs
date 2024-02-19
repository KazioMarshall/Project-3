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

        public string GetCellPhoneNumber(string studentName, string studentNumber)
        {
            return $"{studentName}'s Cell Phone Number: {studentNumber}";
        }

        public string BroadcastMessage()
        {
            return "BroadCast Message: This is the student Cell phone number!";
        }
    }
}
