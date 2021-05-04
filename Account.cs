using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateurDeMonnaies
{
    class Account
    {
        
        decimal total=0;
        struct OperationAndTotal
        {
            public Operation operation;           
            public decimal partialTotal;
        }
        List<OperationAndTotal> accountHistory = new List<OperationAndTotal>();




            ///cette propriété fonctionne comme prévue
        public decimal Total
        {
            get { return total; }
        }

            //PROBLÈME  ?????????????????????????
        public List<OperationAndTotal> AccountHistory
        {
            get { return accountHistory; }
        }
           ///////////////////////////////////////////////
           








        public Account(List<Operation> operations)//Constructor
        {
            BuiltAccountHistory(operations);
        }

        private void BuiltAccountHistory(List<Operation> operations)
        {
            foreach (Operation op in operations)
            {
                OperationAndTotal opAndTotal;
                opAndTotal.operation = op;
                if (opAndTotal.operation.operationType == "deposite")
                {
                    opAndTotal.partialTotal = total += opAndTotal.operation.ammount;
                }
                else if (opAndTotal.operation.operationType == "withdraw")
                {
                    opAndTotal.partialTotal = total -= opAndTotal.operation.ammount;
                }
                else
                {
                    throw new Exception("encounter bad operation type while building accout history");
                }
                accountHistory.Add(opAndTotal);
            }
        }

    }
}
