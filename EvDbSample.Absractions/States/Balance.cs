using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvDbSample.Absractions;
public readonly record struct Balance(string User, double Total)
{
    public readonly static Balance Empty = new Balance();
}
