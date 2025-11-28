using Microsoft.AspNetCore.Components;

namespace BlazorTailwind.Models;

public sealed class ComponentArgs<TComponent> where TComponent : BaseComponent<TComponent>
{
    public string? Class { get; set; }
    public TComponent This { get; set; } = null!;
    public RenderFragment? ChildContent { get; set; }
    public BaseComponent<TComponent> Base { get; set; } = null!;
    public Dictionary<string, object?>? Attributes { get; set; }
}