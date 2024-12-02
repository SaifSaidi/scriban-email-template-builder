using Scriban.Runtime;
using Scriban;

namespace ScribanEmailTemplateBuilder.Services
{
    public class ScribanTemplateRendering : IScribanTemplateRendering
    {
        public async Task<string> Render(string? content, ScriptObject scriptObject)
        {
            if (string.IsNullOrEmpty(content))
                return await Task.FromResult("");
             

            var context = new TemplateContext();
            context.PushGlobal(scriptObject);

            var template = Template.Parse(content);
            return await template.RenderAsync(context);
        }
    }

}
