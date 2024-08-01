using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMicroService.Entities
{
    /// <summary>
    /// Employee Class
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeNo { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Nationality { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public int EmployeeTypeId { get; set; }
        public string SsnNumber { get; set; }
        public string PassportNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }

        public string GetTitle()
        {
            return Title;
        }

        public int GetAge()
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (BirthDate.Year * 100 + BirthDate.Month) * 100 + BirthDate.Day;

            return (a - b) / 10000;
        }

        public string GetEmployeeType()
        {
            return Enum.GetName(typeof(EmployeeType), EmployeeTypeId);
        }

        public string GetSsnNumber()
        {
            return ""; //SsnNumber.FromHexToString();
        }

        public string GetPassportNumber()
        {
            return ""; //PassportNumber.FromHexToString();
        }
    }

    /// <summary>
    /// EmployeeType Enum
    /// </summary>
    public enum EmployeeType
    {
        [Description("Full Time Employee")]
        FTE,
        [Description("Contractor Employee")]
        Contractor
    }
}