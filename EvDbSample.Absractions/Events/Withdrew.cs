using EvDb.Core;

namespace EvDbSample.Absractions;

[EvDbDefineEventPayload("Withdrew")]
public readonly partial record struct Withdrew(Guid Id, double Amount, string User);
