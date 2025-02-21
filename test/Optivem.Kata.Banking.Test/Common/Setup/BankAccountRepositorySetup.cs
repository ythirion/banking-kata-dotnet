﻿using Optivem.Kata.Banking.Core.Domain.BankAccounts;
using static Optivem.Kata.Banking.Test.Common.Builders.Entities.BankAccountBuilder;

namespace Optivem.Kata.Banking.Test.Common.Setup
{
    public static class BankAccountRepositorySetup
    {
        public static void AlreadyContains(this IBankAccountRepository repository, string accountNumber, int balance)
        {
            var bankAccount = BankAccount()
                .AccountNumber(accountNumber)
                .Balance(balance)
                .Build();

            repository.Add(bankAccount);
        }
    }
}