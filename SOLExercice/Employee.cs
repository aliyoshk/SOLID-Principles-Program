using System;
using System.Collections.Generic;
using System.Text;

namespace SOLExercice
{
    public abstract class Employee
    {
        private int _empID;
        private string _loginName;
        private string _password;
        private string _department;
        private string weekendTimeTable;
        private string normalTimeTable;

        public int EmployeeID
        {
            get { return _empID; }
        }

        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Department
        {
            get { return _department; }
        }

        public string WeekendTimeTable
        {
            get { return weekendTimeTable; }
        }

        public string NormalTimeTable
        {
            get { return normalTimeTable; }
        }

        public virtual Boolean Login(string loginName, string password)
        {
            return true;
        }
    }

    public class FullTimeEmployee : Employee
    {
        private int _empID;
        private string _loginName;
        private string _password;
        private string _department;
        private string normalTimeTable;
        public override Boolean Login(string loginName, string password)
        {
            LoginName = loginName;
            Password = Password;

            if (loginName == "aliyu" & password == "abc")
            {
                
                return true; //Returning base Details
            }

            else
            {
                return false;
            }
        }
    }

    public class PartTimeEmployee : Employee
    {
        private int _empID;
        private string _loginName;
        private string _password;
        private string _department;
        private string weekendTimeTable;
        public override Boolean Login(string loginName, string password)
        {
            LoginName = loginName;
            Password = Password;

            if (loginName == "khalifa" & password == "cba")
            {
                _empID = 201;
                _department = "IT Center for Distance Learning";
                return true; //Returning child Details
            }

            else
            {
                return false;
            }
        }
    }
  
}
