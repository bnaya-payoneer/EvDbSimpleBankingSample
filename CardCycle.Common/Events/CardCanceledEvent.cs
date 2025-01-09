using Cards.Common;
using EvDb.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCycle.Common.Events;

[EvDbDefineEventPayload("card-canceled")]
public readonly partial record struct CardCanceledEvent(
                            string DebitCardId);
