using Microsoft.AspNetCore.Components;

namespace BlazorTailwind.Models;

public abstract class BaseComponent<TComponent> : ComponentBase where TComponent : BaseComponent<TComponent>
{
    [Parameter] public string? Class { get; set; }
    [Parameter] public RenderFragment? ChildContent { get; set; }
    [Parameter] public RenderFragment<ComponentArgs<TComponent>>? Body { get; set; }
    [Parameter(CaptureUnmatchedValues = true)] public Dictionary<string, object?>? Attributes { get; set; }
}