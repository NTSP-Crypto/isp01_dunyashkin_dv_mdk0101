using System;

namespace Hierarchy03
{
    class Contract_Employee : Employee
    {
        private float pay_per_hour;
        private string contract_period;

        public Contract_Employee(int id, string name, float pay_per_hour, string contract_period) : base(id, name)
        {
            this.pay_per_hour = pay_per_hour;
            this.contract_period = contract_period;
        }

        public override string ToString()
        {
            return string.Format($"ID: {id}, имя: {name}, оплата за час: {pay_per_hour}, период контракта: {contract_period}");
        }
    }
}
