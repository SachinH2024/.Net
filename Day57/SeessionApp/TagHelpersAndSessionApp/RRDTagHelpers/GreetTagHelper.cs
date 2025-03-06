using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpersAndSessionApp.RRDTagHelpers
{
    public class GreetTagHelper : TagHelper
    {
        public string DevName { get; set; }="DevoloperName";  //dev-name
        public string DevLocation    { get; set; } = "DeveloperLocation "; //dev-location
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h1";
            output.Content.SetHtmlContent($"Hello Developer {DevName}, how is your work @ {DevLocation} welcome to TagHelpers");
        }
    }
}
