using System;
using System.Collections.Generic;
using System.Text;

namespace Facturations.Shared
{
    public class WeatherForecast
    {
        public DateTime DateE { get; set; }

        public DateTime DateR => (DateTime)(DateE.AddDays(15));

        public int NumFacture { get; set; }

        public int MontantR { get; set; }

        public string Client { get; set; }

        public int MontantD => 32 + (int)(MontantR / 0.5556);
    }
}
