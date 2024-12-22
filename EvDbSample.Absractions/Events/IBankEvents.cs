using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvDb.Core;

namespace EvDbSample.Absractions.Events;

[EvDbEventTypes<Deposited>]
[EvDbEventTypes<Withdrew>]
[EvDbEventTypes<CommissionTaken>]
public partial interface IBankEvents
{
}
