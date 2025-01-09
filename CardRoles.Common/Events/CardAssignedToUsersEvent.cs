using EvDb.Core;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardRoles.Common.Events;

[EvDbDefineEventPayload("card-assigned-to-user")]
public readonly partial record struct CardAssignedToUsersEvent(
                            string DebitCardId, 
                            ImmutableArray<string> UserIds);
