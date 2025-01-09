using CardCycle.Common.Events;
using Cards.Repositories.EventsInterfaces;
using Cards.Repositories.Views;
using EvDb.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Repositories.Factories;

[EvDbAttachView<CardView>]
[EvDbStreamFactory<ICardsEvents>("cards", "card")]
public partial class CardFactory//: ICardCycleEvents
{
}
