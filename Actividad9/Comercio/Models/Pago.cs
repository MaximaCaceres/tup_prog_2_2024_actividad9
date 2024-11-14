using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLib.Models
{
    public class Pago:Ticket
    {
        CuentaCorriente ficha;
        public Pago(CuentaCorriente C)
        {
            ficha = C;
        }
        public CuentaCorriente VerCC()
        {
            return ficha;
        }
    }
}
