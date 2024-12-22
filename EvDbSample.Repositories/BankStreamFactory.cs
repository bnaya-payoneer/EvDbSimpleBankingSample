using EvDb.Core;
using EvDbSample.Absractions.Events;
using EvDbSample.Repositories.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvDbSample.Repositories;

[EvDbAttachView<BalanceView>("MyBalance")]
[EvDbStreamFactory<IBankEvents>("banking", "local-bank")]
public partial class BankStreamFactory
{
}
