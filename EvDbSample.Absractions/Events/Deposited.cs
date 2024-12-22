using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EvDb.Core;


namespace EvDbSample.Absractions;

[EvDbDefineEventPayload("deposited")]
public readonly partial record struct Deposited (Guid Id, double Value, string User);
