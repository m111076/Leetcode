using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2043_Simple_Bank_System
    {
        //runtime 96%
        public class Bank
        {
            private long[] accounts;
            public Bank(long[] balance)
            {
                accounts = balance;
            }

            public bool Transfer(int account1, int account2, long money)
            {
                if (account1 > accounts.Length || account2 > accounts.Length || accounts[account1 - 1] < money)
                    return false;
                else
                {
                    accounts[account1 - 1] -= money;
                    accounts[account2 - 1] += money;
                    return true;
                }
            }

            public bool Deposit(int account, long money)
            {
                if (account > accounts.Length)
                    return false;
                else
                {
                    accounts[account - 1] += money;
                    return true;
                }
            }

            public bool Withdraw(int account, long money)
            {
                if (account > accounts.Length || accounts[account - 1] < money)
                    return false;
                else
                {
                    accounts[account - 1] -= money;
                    return true;
                }
            }
        }
    }
}
