using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacjaProstaGra
{
    public class Statistic
    {

#pragma warning disable CS8618 // Pole niedopuszczające wartości null musi zawierać wartość inną niż null podczas kończenia działania konstruktora. Rozważ zadeklarowanie pola jako dopuszczającego wartość null.
        public string Name { get; set; }
#pragma warning restore CS8618 // Pole niedopuszczające wartości null musi zawierać wartość inną niż null podczas kończenia działania konstruktora. Rozważ zadeklarowanie pola jako dopuszczającego wartość null.
        public int Points { get; set; }
    }
}
