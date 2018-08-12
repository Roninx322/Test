using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Test
    {
        public bool Transfer(Account from, Account to, double amount)
        {
            double balance = from.Balance - amount;//в данном случае не есть хорошо работать с переданным классом лучше через переменную потому что если сразу вычесть из класса то оно сохранит изменения 
            if (balance < 0) return false;//думая нельзя что бы был минусавой баланс ))
            else
            {
                from.Balance -= amount;
                to.Balance += amount;//to.Balance = from.Balance + amount; было явной ошибкой
                return true;
            }
        }
    }
}
