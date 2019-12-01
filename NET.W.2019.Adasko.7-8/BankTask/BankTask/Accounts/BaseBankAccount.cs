﻿using System;
namespace BankTask.Accounts
{
    [Serializable]
    public class BaseBankAccount : BankAccount
    {
        public BaseBankAccount(int id, string name) : base(id, name)
        {
        }

        public BaseBankAccount(int id, string name, decimal balance, double bonusPoints)
            : base(id, name, balance, bonusPoints)
        {
        }

        public override double DepositBalanceCoefficient => 0.1;

        public override double DepositValueCoefficient => 0.1;

        public override double WithdrawBalanceCoefficient => 0.05;

        public override double WithdrawValueCoefficient => 0.05;
    }
}