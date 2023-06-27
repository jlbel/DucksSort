using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
     class Duck: IComparable<Duck>
    {
        public override string ToString()
        {
            return $"A {Size} inch {Kind}";
        }
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }
        public int CompareTo(Duck duckToComprate)
        {
            if (this.Size > duckToComprate.Size) return 1;
            else if (this.Size < duckToComprate.Size) return -1;
            else return 0;
        }
    }
   
    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Loon,
    }

}
