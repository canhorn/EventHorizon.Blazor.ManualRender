using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace EventHorizon.Blazor.ManualRender.Pages.Components
{
    /// This Component is completely generated in C#, without the use of any .razor file.
    public class GameAgentDetails : ComponentBase
    {
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public string Role { get; set; }
        [Parameter]
        public string Function { get; set; }

        // This is the BuildRenderTree, we can use this to build from scratch the HTML that will be placed on the page.
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            var seq = 0;
            // We open a div
            builder.OpenElement(seq, "div");
            // Adding a arbitrary class attribute with a custom value.
            builder.AddAttribute(++seq, "class", "agent-details__name");
            // Then add some content to that the div, in this case the passed in Name parameter.
            builder.AddContent(++seq, Name);
            // We then close the currently open element.
            builder.CloseElement();
            
            builder.OpenElement(++seq, "div");
            builder.AddAttribute(++seq, "class", "agent-details__role");
            builder.AddContent(++seq, Role);
            builder.CloseElement();

            builder.OpenElement(++seq, "div");
            builder.AddAttribute(++seq, "class", "agent-details__function");
            builder.AddContent(++seq, Function);
            builder.CloseElement();
        }
    }
}