using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace stopwatch
{
    public  class APIPassWorldClock
    {
        public DateTimeOffset Datetimed { get; set; }

  
        public string Timezoned { get; set; }
        public void PassAPIWorldWatch(WAPIPassWorldClock teste)
        {
            Datetimed = teste.Datetime;
            this.Timezoned = teste.Timezone;
        }

        public string ViewWorldWatch()
        {
            return $"{Timezoned} - {Datetimed} UTC {Datetimed.UtcDateTime.ToLongTimeString()}";
        }
    }
}
