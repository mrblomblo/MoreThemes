using SwarmUI.Core;
using SwarmUI.Utils;
using SwarmUI.Text2Image;
using SwarmUI.Builtin_ComfyUIBackend;
using Newtonsoft.Json.Linq;

namespace Blomblo.Extensions.MoreThemes;

public class MoreThemes : Extension
{
    public override void OnPreInit()
    {
        OtherAssets.Add("Assets/test.css");
    }

    public override void OnInit()
    {
        // set extension metadata
        ExtensionName = "More Themes";
        Version = "0.1.0";
        ExtensionAuthor = "Blomblo";
        Description = "Adds more themes";
        License = "MIT";
        Tags = ["theming"];

        Logs.Init("More Themes Extension initializing...");

        Program.Web.RegisterTheme(new("test_theme_69", "Theme Name 1", ["css/themes/modern.css", "/ExtensionFile/MoreThemes/Assets/test.css"], true));

        Logs.Init("More Themes Extension initialized successfully");
    }
}
