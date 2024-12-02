using Scriban.Runtime;

namespace ScribanEmailTemplateBuilder.Services
{
    public interface IScribanTemplateRendering
    {
        public Task<string> Render(string? content, ScriptObject scriptObject);
    }

}
