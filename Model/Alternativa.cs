namespace Aplicacion_Desintoxicacion.Model
{
    public enum Estado
    {
        Recomendada = 0,
        NoRecomendada = 1
    }

    public class Alternativa
    {
        //Atributos / Propiedades        
        public string? encargado;
        public double tempAzufre = 444.6;
        public double masaAzufre = 32.07;
        public double porcentajeAzufre;
        public double tempEbullicion;
        public double tiempoImplementacion;
        public double IV;
        public double costoInicial;
        public double costoFinal;


        //Metodos
        public void GetIV()
        {
            IV = costoInicial / costoFinal;
        }

        public void GetTemp()
        {
            if (tempEbullicion > tempAzufre)
            {
                IV = Math.Sign(-IV) * IV;
            }
        }

        public void GetPercent()
        {
            IV += (masaAzufre * (porcentajeAzufre / 100));
        }

        public void Time()
        {
            IV *= tiempoImplementacion;

            IV /= tiempoImplementacion;
        }

        public double Total()
        {
            GetIV();
            GetTemp();
            GetPercent();
            Time();

            return Math.Round(IV,2);
        }

        public int Est()
        {
            IV = Total();

            if (IV > 1.54)
            {
                return 0;
            }

            else
            {
                return 1;
            }
        }
    }
}

