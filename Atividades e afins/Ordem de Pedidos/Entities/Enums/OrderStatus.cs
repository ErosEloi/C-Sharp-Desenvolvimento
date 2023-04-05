using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemPedidos.Entities.Enums
{
    internal enum OrderStatus : int
    {

        Pending_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Deliverd = 3

    }
}
