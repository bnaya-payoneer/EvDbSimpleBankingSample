namespace EvDbSample.Absractions;

public readonly record struct LastActions (string User, ActionLog[] logs);
