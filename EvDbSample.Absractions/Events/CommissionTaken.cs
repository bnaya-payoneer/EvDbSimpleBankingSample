using EvDb.Core;

namespace EvDbSample.Absractions;

[EvDbDefineEventPayload("commission-taken")]

public readonly partial record struct CommissionTaken(Guid Id, string User, double Value);
