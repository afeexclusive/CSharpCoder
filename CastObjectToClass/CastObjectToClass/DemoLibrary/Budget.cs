using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoLibrary
{
    internal class Budget
    {
        private readonly decimal[] incomes;
        private readonly decimal[] expenses;

        private string BudgetYear { get; set; }
        private decimal TotalIncome { get; set; }
        private decimal TotalExpense { get; set; }

        internal Budget(decimal[] incomes, decimal[] expenses, DateTime dateOfReview)
        {
            BudgetYear = dateOfReview.Year.ToString();
            this.incomes = incomes;
            this.expenses = expenses;
        }

        internal BudgetSummary GetBudgetSummary()
        {
            TotalIncome = incomes.Sum();
            TotalExpense = expenses.Sum();
            BudgetSummary budgetSummary = new BudgetSummary()
            {
                BudgetYear = BudgetYear,
                Income = TotalIncome,
                Expense = TotalExpense,
                Deficit = TotalExpense > TotalIncome ? TotalExpense - TotalIncome : decimal.Zero,
                Suplus = TotalIncome > TotalExpense ? TotalIncome - TotalExpense : decimal.Zero
            };

            return budgetSummary;
        }

    }
}
