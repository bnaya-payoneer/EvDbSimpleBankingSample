using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvDb.Core;
using EvDbSample.Absractions;
using EvDbSample.Absractions.Events;

namespace EvDbSample.Repositories.Views;

[EvDbViewType<Balance, IBankEvents>("balance")]
public partial class BalanceView
{
    protected override Balance DefaultState { get; } = Balance.Empty;

    public override int MinEventsBetweenSnapshots { get; } = 1;

    protected override Balance Fold(Balance state, Deposited payload, IEvDbEventMeta meta)
    {
        var result = state;
        result = result with { Total = state.Total + payload.Value  };
        return result;
    }

    protected override Balance Fold(Balance state, CommissionTaken payload, IEvDbEventMeta meta)
    {
        var result = state;
        result = result with { Total = state.Total + payload.Value };
        return result;
    }
}
