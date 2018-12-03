using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public interface IAccount
    {
        // wplacic pieniadze na konto
        void Put(decimal sum);
        // Pobrac z konta
        decimal Withdraw(decimal sum);
    }
}
