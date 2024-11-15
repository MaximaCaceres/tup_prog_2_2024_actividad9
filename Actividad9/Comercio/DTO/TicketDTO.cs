﻿using ComercioLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioLib.DTO
{
    public class TicketDTO
    {
        public int tipo { get; set; }
        public int Nroorden { get; set; }
        public DateTime fechaHora { get; set; }
        public CuentaCorriente ficha { get; set; }
        public long dni { get; set; }

        public TicketDTO(Ticket ticket)
        {
            Nroorden = ticket.VerNro();
            fechaHora = ticket.VerFecha();
            if(ticket is Cliente cliente)
            {
                tipo = 1;
                this.dni = cliente.VerDNI();
            }
            else if (ticket is Pago pago)
            {
                tipo = 2;
                this.ficha = pago.VerCC();
            }
        }
    }
}
