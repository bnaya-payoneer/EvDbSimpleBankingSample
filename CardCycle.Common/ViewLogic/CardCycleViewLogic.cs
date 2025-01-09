using CardCycle.Common.Events;
using EvDb.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CardCycle.Common;
using Cards.Common;

namespace CardCycle.Common.ViewLogic;

public static class CardCycleViewLogic
{
    public static CardState Fold(
            CardState state,
            CardCanceledEvent payload,
            IEvDbEventMeta meta)
            {
                CardState newState = state with
                {
                    DebitCardId = payload.DebitCardId,
                    Status = CardStatus.Canceled,
                };
                return newState;
            }
}
