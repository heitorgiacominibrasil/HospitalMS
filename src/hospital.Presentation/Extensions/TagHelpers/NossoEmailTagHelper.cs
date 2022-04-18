using Microsoft.AspNetCore.Razor.TagHelpers;

namespace mvc.Extensions.TagHelpers
{
    public class NossoEmailTagHelper : TagHelper
    {
        public string Dominio { get; set; } = "outlook.com.br";
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var prefixo = await output.GetChildContentAsync();
            var meuemail = prefixo.GetContent() + "@"+ Dominio;
            output.Attributes.SetAttribute("href", "mailto:" + meuemail);
            output.Content.SetContent(meuemail);    

        }
    }
}
