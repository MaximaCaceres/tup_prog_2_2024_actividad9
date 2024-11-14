using ComercioLib.DTO;
using ComercioLib.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiServicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComercioController : ControllerBase
    {
        readonly static Comercio com = new Comercio();//readonli static se instancia y no se toca mas.
        [HttpGet("AgregarTicket")]
        public IActionResult GetAgregarTicket(int tipo,string dni, int nroCC)//parecido al evento del boton
        {
            Ticket t = null;
            if (tipo == 1)
            {
                t = new Cliente(dni);
            }
            else 
            {
                if (tipo == 2)
                {
                    
                    CuentaCorriente cc = com.VerCC(nroCC);
                    if(cc!= null)
                    {
                        t = new Pago(cc);
                    }
                    
                }
            }
            if(t != null)
            {
                com.AgregarTicket(t);
                return Ok("turno solicitado ok!");
            }
            return  NoContent(); //mando un mensajito con cierto contenido a al cliente
        }
        [HttpGet("AgregarCuentaCorriente")]
        public IActionResult GetAgregarCuentaCorriente(string dni, int nroCC)//parecido al evento del boton
        {
            com.AgregarCuentaCorriente(nroCC, dni);
            if (nroCC != null) return Ok("La cuenta fue agregada");
            return NoContent(); //mando un mensajito con cierto contenido a al cliente
        }
        [HttpGet("AtenderTicket")]
        public IActionResult GetAtenderTicket(int tipo)
        {
            Ticket atendido = com.AtenderTicket(tipo);
            if (atendido != null)
            {
                TicketDTO dto = new TicketDTO(atendido);
                return Ok(dto);
            }
            return Ok(atendido);
            return NotFound("No ser encontraron tickets");
        }
    }
}
