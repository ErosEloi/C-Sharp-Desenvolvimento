using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeContratos.Entities
{
    class HourContract
    {

        public DateTime Date { get; set; }
        public double valuePerHour { get; private set; }
        public int hour { get; private set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            this.valuePerHour = valuePerHour;
            this.hour = hour;
        }

        public double totalValue()
        {
            return this.valuePerHour * this.hour;
        }
    }
}
