using EvDb.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCycle.Common.Events;

[EvDbEventTypes<CardCanceledEvent>]
public partial interface ICardCycleEvents
{
}

