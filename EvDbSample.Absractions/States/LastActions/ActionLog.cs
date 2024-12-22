namespace EvDbSample.Absractions;

public readonly record struct ActionLog (string User, ActionType Type, double Value, double Commision = 0);
