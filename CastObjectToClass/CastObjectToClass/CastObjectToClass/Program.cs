using DemoAPI;
using DemoLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CastObjectToClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use case 1.
            //Consume the API
            Controller api = new Controller();
            string response = api.GetAllEmployees();
            string oneResponse = api.GetOneEmployee(2);

            //The API custom return model is coming as JSON string and is collected in the response


            ReturnModel resultlist = JsonConvert.DeserializeObject<ReturnModel>(response);
            ReturnModel result = JsonConvert.DeserializeObject<ReturnModel>(oneResponse);

            //step 1. change the target object to json using Serialize using Newtonsoft or .Tostring()

            string employeesJson = JsonConvert.SerializeObject(resultlist.ReturnObj);
            string employeesString = resultlist.ReturnObj.ToString();

            //or

            string oneemployeeJson = JsonConvert.SerializeObject(result.ReturnObj);
            string oneemployeeString = result.ReturnObj.ToString();



            //step 2. Convert to your desired class using Newtonsoft

            List<Employee> employees1 = JsonConvert.DeserializeObject<List<Employee>>(employeesJson);
            List<Employee> employees2 = JsonConvert.DeserializeObject<List<Employee>>(employeesString);

            //or

            Employee employee = JsonConvert.DeserializeObject<Employee>(oneemployeeJson);
            Employee employee2 = JsonConvert.DeserializeObject<Employee>(oneemployeeString);




            //Use case 2.
            // A library that return data using the object type

            var budgetDetails = new DemoLibrary.BudgetDetail();
            var budgetSummar = 
                budgetDetails.ProcessBudget(new decimal[]{ 2.20M, 4.00M, 19.00M }, new decimal[]{ 2.20M, 4.50M, 5.00M }, DateTime.Now);

            // Note that you cannot use .ToString() option here because this project is aware of returning object origin so it can through reflection implicitly assign a name to it.

            string budgetJson = JsonConvert.SerializeObject(budgetSummar);

            Budget budget = JsonConvert.DeserializeObject<Budget>(budgetJson);

        }
    }

    class Employee
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

    class Budget
    {
        public string BudgetYear { get; set; }
        public decimal Income { get; set; }
        public decimal Expense { get; set; }
        public decimal Suplus { get; set; }
        public decimal Deficit { get; set; }

    }

   
}


//new decimal[] { 2.20M, 4.00M, 4.04M},
//new decimal[] { 2.20M, 4.50M, 5.00M .00M },