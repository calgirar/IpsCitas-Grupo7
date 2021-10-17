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
            string[] hours = { 
            "7:00", "7:15", "7:30", "7:45",
            "8:00", "8:15", "8:30", "8:45", 
            "9:00", "9:15", "9:30", "9:45", 
            "10:00", "10:15", "10:30", "10:45", 
            "11:00", "11:15", "11:30", "11:45", 
            "12:00", "12:15", "12:30", "12:45", 
            "1:00", "1:15", "1:30", "1:45", 
            "2:00", "2:15", "2:30", "2:45", 
            "3:00", "3:15", "3:30", "3:45", 
            "4:00", "4:15", "4:30", "4:45", 
            "5:00", "5:15", "5:30", "5:45", 
            "6:00", "6:15", "6:30", "6:45",
            }; 
            
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
