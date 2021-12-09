using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    internal struct BudgetSummary
    {

        public string BudgetYear { get; set; }
        public decimal Income { get; set; }
        public decimal Expense { get; set; }
        public decimal Suplus { get; set; }
        public decimal Deficit { get; set; }
    }

    public class BudgetDetail
    {
        public object ProcessBudget(decimal[] incomes, decimal[] expenses, DateTime dateOfReview)
        {
            var result = new Budget(incomes, expenses, dateOfReview);

            return result.GetBudgetSummary();
        }
    }
}
