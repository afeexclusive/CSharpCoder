using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoAPI
{
    public class Controller
    {
        public string GetAllEmployees()
        {
            ReturnModel model = new ReturnModel
            {
                Message = "Successful",
                Status = true,
                ReturnObj = employees //Yes this is possible because every class inherits from sytem.object

            };
            return JsonConvert.SerializeObject(model);
        }

        public string GetOneEmployee(int id)
        {
            ReturnModel model = new ReturnModel
            {
                Status = true,
                Message = "Successful",
                ReturnObj = employees.FirstOrDefault(x => x.UserId == id)
            };
            return JsonConvert.SerializeObject(model);
        }


        private List<Employees> employees = new List<Employees>()
        {
            new Employees
            {
                UserId = 1,
                JobTitleName = "Developer",
                FirstName = "Romin",
                LastName = "Irani",
                PreferredFullName="Romin Irani",
                EmployeeCode="E1",
                Region="CA",
                PhoneNumber="408-1234567",
                EmailAddress="romin.k.irani@gmail.com"
            },
            new Employees
            {
                UserId=2,
                JobTitleName="Developer",
                FirstName="Neil",
                LastName="Irani",
                PreferredFullName="Neil Irani",
                EmployeeCode="E2",
                Region="CA",
                PhoneNumber="408-1111111",
                EmailAddress="neilrirani@gmail.com"

            },
            new Employees
            {
                UserId=3,
                JobTitleName="Program Directory",
                FirstName="Tom",
                LastName="Hanks",
                PreferredFullName="Tom Hanks",
                EmployeeCode="E3",
                Region="CA",
                PhoneNumber="408-2222222",
                EmailAddress="tomhanks@gmail.com"
            }
        };
    }

    internal class Employees
    {
        public int UserId { get; set; }
        public string JobTitleName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PreferredFullName { get; set; }
        public string EmployeeCode { get; set; }
        public string Region { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}

