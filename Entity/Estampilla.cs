namespace Entity
{
    public class Estampilla
    {
        public string NumeroDeContrato { get; set; }
        public string ObjetoDelContrato { get; set; }
        public decimal ValorDelContrato { get; set; }
        public string ApoyaEmergenciaCovid19 { get; set; }
        public decimal ValorEstampilla { get; set; }

        public void CalcularEstampilla()
        {
            if (ApoyaEmergenciaCovid19.Equals("SI"))
            {
                ValorEstampilla=(ValorDelContrato*1)/100;
            }else{
                ValorEstampilla=(ValorDelContrato*2)/100;
            }
            }
        
    }
}