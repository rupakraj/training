using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TagTest2.Code
{
    public class Student
    {
        private int _stuID;
        public int StudentID
        {
            get { return _stuID; }
            set { _stuID = value; }
        }
        public string StudentName { get; set; }
        public string ClassName { get; set; }
        public int RollNO { get; set; }
        public string Gender { get; set; }
        public string Qualificattion { get; set; }

    }
}