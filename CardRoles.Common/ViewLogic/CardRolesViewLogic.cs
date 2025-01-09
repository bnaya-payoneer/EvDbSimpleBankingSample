using CardRoles.Common.Events;
using Cards.Common;
using EvDb.Core;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardRoles.Common.ViewLogic;
public static class CardRolesViewLogic
{
    public static CardState Fold(
                CardState state,
                CardAssignedToUsersEvent payload,
                IEvDbEventMeta meta)
    {
        var users = state.UserIds.Union(payload.UserIds)
                        .ToImmutableArray();
        CardState newState = state with
        {
            DebitCardId = payload.DebitCardId,
            UserIds = users            
        };

        return newState;
    }

}
