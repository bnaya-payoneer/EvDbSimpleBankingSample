using CardCycle.Common.Events;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Repositories.States;

public readonly partial record struct CardState(string DebitCardId)
{
    public CardStatus Status { get; init; }
    public ImmutableArray<string> UserIds { get; init; } = ImmutableArray<string>.Empty;
}
