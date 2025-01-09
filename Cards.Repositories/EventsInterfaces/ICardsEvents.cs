using CardCycle.Common.Events;
using CardRoles.Common.Events;
using EvDb.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Repositories.EventsInterfaces;

[EvDbEventTypes<CardCanceledEvent>]
[EvDbEventTypes<CardAssignedToUsersEvent>]
public partial interface ICardsEvents
{
}
