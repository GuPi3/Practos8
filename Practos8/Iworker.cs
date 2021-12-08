using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practos8
{
    interface Iworker
    {
        public int Payment { get; set; }
        public string Name { get; set; }
        public string GetInfo();
        public int Pay();
    }
    class Salary : Iworker, IComparable
    {

        public int Payment { get; set; }
        public string Name { get; set; }
        public string GetInfo()
        {
            return "Работник:" + Name + "\nЗарплата:" + Payment;
        }
        public int Pay()
        {
            return Payment;
        }
        public Salary(int salary, string name)
        {
            Name = name;
            Payment = salary;
        }
        public int CompareTo(object obj)
        {
            Salary salary = (Salary)obj;
            if (Convert.ToChar(Name.Substring(0, 1)) < Convert.ToChar(salary.Name.Substring(0, 1))) return 1; 
            if (Convert.ToChar(Name.Substring(0,1)) > Convert.ToChar(salary.Name.Substring(0,1))) return -1;
            return 0;
        }
    }
    class HourlyPayment : Iworker, IComparable
    {
        public int Payment { get; set; }
        public string Name { get; set; }
        public string GetInfo()
        {
            return "Работник:" + Name + "\nЗарплата в час:" + Payment;
        }
        public int Pay() 
        {

            return Payment;
        }
        public HourlyPayment(int salary, string name)
        {
            Name = name;
            Payment = salary;
        }
        public int CompareTo(object obj)
        {
            Salary salary = (Salary)obj;
            if (Convert.ToChar(Name.Substring(0, 1)) < Convert.ToChar(salary.Name.Substring(0, 1))) return 1;
            if (Convert.ToChar(Name.Substring(0, 1)) > Convert.ToChar(salary.Name.Substring(0, 1))) return -1;
            return 0;
        }
    }
}
