namespace Aplicacion_Desintoxicacion.Model
{   
    public class ListaAlternativas
    {
        public List<Alternativa> alternativas = new List<Alternativa>();               

        public ListaAlternativas()
        {                                   
            alternativas.Add(new Alternativa()
            {                
                encargado = "Samuel",
                tempEbullicion = 500,
                tiempoImplementacion = 8,
                costoInicial = 30,
                costoFinal = 10,
                porcentajeAzufre = 10
            });
            
            alternativas.Add(new Alternativa()
            {                
                encargado = "Natalia",
                tempEbullicion = 200,
                tiempoImplementacion = 10,
                costoInicial = 1000,
                costoFinal = 2000,
                porcentajeAzufre = 10
            });
        }

        public List<Alternativa> Show()
        {
            return alternativas;
        }

        public Alternativa? ShowOne(string encargado)
        {
            return alternativas.FirstOrDefault(a => a.encargado == encargado);
        }
       
    }
}

