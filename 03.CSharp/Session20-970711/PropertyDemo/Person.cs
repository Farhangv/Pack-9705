using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo
{
    class Person
    {
        private string name;
        private string family;
        private string nationalCode;
        private DateTime birthDate;

        public string Name
        {
            get
            {
                return name;
            }

            set {
                name = value;
            }
        }
        public string Family
        {
            get { return family; }
            set { family = value; }
        }
        public string FatherName { get; set; }
        public string NationalCode
        {
            get {
                if (nationalCode != "0000000000")
                    return $"{nationalCode.Substring(0, 3)}-{nationalCode.Substring(3, 6)}-{nationalCode.Substring(9, 1)}";
                else
                    return "Invalid";
            }
            set {
                if (_nationalCode.Length == 10)
                    nationalCode = _nationalCode;
                else
                {
                    Console.WriteLine("Invalid National Code Entered!");
                    nationalCode = "0000000000";
                }
            }
        }

        public string BirthDate
        {
            get
            {
                PersianCalendar pc = new PersianCalendar();
                var year = pc.GetYear(birthDate);
                var month = pc.GetMonth(birthDate);
                var day = pc.GetDayOfMonth(birthDate);

                return $"{year:0000}/{month:00}/{day:00}";

            }

            set {
                PersianCalendar pc = new PersianCalendar();
                var dateParts = value.Split('/');
                birthDate = pc.ToDateTime(int.Parse(dateParts[0]), int.Parse(dateParts[1]), int.Parse(dateParts[2]), 0, 0, 0, 0);

            }
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - birthDate.Year;
            }
        }


        #region GetterSetters

        public int getAge()
        {
            return DateTime.Now.Year - birthDate.Year;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string _name)
        {
            name = _name;
        }

        public string getFamily()
        {
            return family;
        }

        public void setFamily(string _family)
        {
            family = _family;
        }

        public void setNationalCode(string _nationalCode)
        {
            if (_nationalCode.Length == 10)
                nationalCode = _nationalCode;
            else
            {
                Console.WriteLine("Invalid National Code Entered!");
                nationalCode = "0000000000";
            }

        }

        public string getNationalCode()
        {
            if (nationalCode != "0000000000")
                return $"{nationalCode.Substring(0, 3)}-{nationalCode.Substring(3, 6)}-{nationalCode.Substring(9, 1)}";
            else
                return "Invalid";
        }

        public string getBirthDate()
        {
            PersianCalendar pc = new PersianCalendar();
            var year = pc.GetYear(birthDate);
            var month = pc.GetMonth(birthDate);
            var day = pc.GetDayOfMonth(birthDate);

            return $"{year:0000}/{month:00}/{day:00}";
        }

        public void setBirthDate(string _birthDate)
        {
            PersianCalendar pc = new PersianCalendar();
            var dateParts = _birthDate.Split('/');
            birthDate = pc.ToDateTime(int.Parse(dateParts[0]), int.Parse(dateParts[1]), int.Parse(dateParts[2]), 0, 0, 0, 0);

        }

        #endregion
    }
}
