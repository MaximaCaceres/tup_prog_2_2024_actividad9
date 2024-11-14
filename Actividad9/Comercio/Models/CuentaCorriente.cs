using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLib.Models
{
    public class CuentaCorriente:IComparable<CuentaCorriente>
    {
        Cliente titular;
        int nroCuenta;
        double saldo;

        public CuentaCorriente(int nroCueenta,Cliente titular)
        {
            this.titular = titular;
            this.nroCuenta = nroCueenta;
        }
        public int CompareTo(CuentaCorriente? other)
        {
            if(other != null) return nroCuenta.CompareTo(other.nroCuenta);
            return 1;
        }
    }
}
