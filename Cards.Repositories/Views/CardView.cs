using CardCycle.Common.Events;
using CardCycle.Common.ViewLogic;
using CardRoles.Common.Events;
using CardRoles.Common.ViewLogic;
using Cards.Common;
using Cards.Repositories.EventsInterfaces;
using EvDb.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Repositories.Views;

[EvDbViewType<CardState, ICardsEvents>("card")]
public partial class CardView
{
    protected override CardState DefaultState { get; } = new CardState();

    protected override CardState Fold(
        CardState state, 
        CardCanceledEvent payload,
        IEvDbEventMeta meta)
    {
        CardState newState = CardCycleViewLogic.Fold(state, payload, meta);
        return newState;
    }

    protected override CardState Fold(CardState state, CardAssignedToUsersEvent payload, IEvDbEventMeta meta)
    {
        CardState newState = CardRolesViewLogic.Fold(state,payload,meta);
        return newState;    
    }


}
