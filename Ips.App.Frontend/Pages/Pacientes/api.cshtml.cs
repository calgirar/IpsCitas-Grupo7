using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ips.App.Dominio;
using Ips.App.Persistencia;

namespace Ips.App.Frontend.Pages
{
    public class apiModel : PageModel
    {

        private readonly IRepositorioHorario _repoHorario;
        public apiModel(IRepositorioHorario repoHorario)
        {
            _repoHorario= repoHorario;
        }
        
        public IActionResult OnGet(string date)
        {
            string[] hours = { "7:0", "7:30", "8:0", "8:30", "9:0", "9:30"}; 
            
            /*
            var hours = new Dictionary<string, int>(){
                {"7:0", 0},
                {"7:30", 1},
                {"8:0", 2},
                {"8:30", 3},
                {"9:0", 4},
                {"9:30", 5}
            };*/

            string[] date_s = date.Split('-');
            var horario = _repoHorario.ObtenerTodosHorarios();
            foreach (var item in horario)
            {
                if (Int32.Parse(date_s[0]) == item.FechaHorario.Year)
                {
                    if (Int32.Parse(date_s[1]) == item.FechaHorario.Month){
                        if (Int32.Parse(date_s[2]) == item.FechaHorario.Day){
                            var hora = item.FechaHorario.Hour+":"+item.FechaHorario.Minute;
                            //hours.Remove(hora);
                            hours = hours.Where(val => val != hora).ToArray();
                        }
                    }
                }
            }
            return new JsonResult(new { disponibilidad  = hours } );
        }
    }
}
