using Microsoft.AspNetCore.Components;

namespace BlazorTailwind.Base;

public sealed class ComponentArgs<TComponent> where TComponent : ComponentBase<TComponent>
{
    public string? Id { get; set; }
    public string? Class { get; set; }
    public string? Style { get; set; }
    public TComponent This { get; set; } = null!;
    public RenderFragment? ChildContent { get; set; }
    public ComponentBase<TComponent> Base { get; set; } = null!;
    public Dictionary<string, object?>? Attributes { get; set; }
}