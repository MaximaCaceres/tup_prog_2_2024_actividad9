using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLib.Models
{
    public class Cliente:Ticket
    {
        long dni;
        static int numInicio = 0;
        public Cliente(string dni)
        {
            this.dni = Convert.ToInt64(dni);
            if (this.dni < 3000000 || this.dni > 45000000) throw new Exception("");
        }
        public long VerDNI()
        {
            return dni;
        }

    }
}
