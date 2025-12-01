using Microsoft.AspNetCore.Components;

namespace BlazorTailwind.Base;

public class ComponentBase<TComponent> : ComponentBase where TComponent : ComponentBase<TComponent>
{
    [Parameter] public string? Id { get; set; }
    [Parameter] public string? Class { get; set; }
    [Parameter] public string? Style { get; set; }
    [Parameter] public RenderFragment? ChildContent { get; set; }
    [Parameter] public RenderFragment<ComponentArgs<TComponent>>? RootElement { get; set; }
    [Parameter(CaptureUnmatchedValues = true)] public Dictionary<string, object?>? Attributes { get; set; }
}