using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEstampillas.Models
{
    public class EstampillaInputModel
    {
        public string NumeroDeContrato { get; set; }
        public string ObjetoDelContrato { get; set; }
        public decimal ValorDelContrato { get; set; }
        public string ApoyaEmergenciaCovid19 { get; set; }
        
    }
    public class EstampillaViewModel : EstampillaInputModel
    {
        public EstampillaViewModel()
        {

        }
        public EstampillaViewModel(Estampilla estampilla)
        {
            NumeroDeContrato = estampilla.NumeroDeContrato;
            ObjetoDelContrato = estampilla.ObjetoDelContrato;
            ValorDelContrato = estampilla.ValorDelContrato;
            ApoyaEmergenciaCovid19 = estampilla.ApoyaEmergenciaCovid19;
            ValorEstampilla = estampilla.ValorEstampilla;  
        }
        public decimal ValorEstampilla { get; set; }
    }

}