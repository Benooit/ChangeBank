using System;

namespace CalculateurDeMonnaies
{     
        struct Operation 
        {
            public string operationType { get; }
            public decimal ammount { get; }            
            public DateTime date { get; }

            public Operation(string operationType, decimal ammount)
            {
                this.operationType = operationType;
                this.ammount = ammount;
                this.date = DateTime.Now;
            }
        }


}

