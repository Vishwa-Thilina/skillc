using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class user
    {
        public string name;
        public string password;
        public string phone;
        public string address;
        public string

    }
    public class patient : user
    {
        public string name;
        public string phone;
        public string address;
        public string email;
    }
    public class doctor : user
    {
        public string name;
        public string phone;
        public string address;
        public string email;
        public string specialization;
    }
    public class appointment : doctor
    {
        public string patientName;
        public string doctorName;
        public string date;
        public string time;
    }
    public class prescription : doctor
    {
        public string patientName;
        public string doctorName;
        public string date;
        public string time;
        public string medicine;
        public string dosage;
        public string duration;
    }
    public class report : doctor
    {
        public string patientName;
        public string doctorName;
        public string date;
        public string time;
        public string reportType;
        public string reportDetails;
    }
    public class payment : doctor
    {
        public string patientName;
        public string doctorName;
        public string date;
        public string time;
        public string amount;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
