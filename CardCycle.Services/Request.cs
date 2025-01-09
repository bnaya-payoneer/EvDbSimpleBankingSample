namespace CardCycle.Services;

public readonly record struct Request
{
    public string DebitCardId { get; init; }
    public string Status { get; init; }
    public string StatusLocationChange { get; init; } 
    public bool ForceSetStatus { get; init; } 
    public bool SendIpcnNotification { get; init; }
    public Guid RequestReferenceId { get; init; } 
    public int SystemComponentId { get; init; } 
}
