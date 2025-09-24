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
        OtherAssets.Add("Assets/ctp_background.css");
        OtherAssets.Add("Assets/ctp_background.png");
        OtherAssets.Add("Assets/nord_polar_night.css");
        OtherAssets.Add("Assets/nord_snow_storm.css");
        OtherAssets.Add("Assets/rose_pine.css");
        OtherAssets.Add("Assets/rose_pine_moon.css");
        OtherAssets.Add("Assets/rose_pine_dawn.css");
        OtherAssets.Add("Assets/gruvbox_dark_hard.css");
        OtherAssets.Add("Assets/gruvbox_dark.css");
        OtherAssets.Add("Assets/gruvbox_dark_soft.css");
        OtherAssets.Add("Assets/gruvbox_light_hard.css");
        OtherAssets.Add("Assets/gruvbox_light.css");
        OtherAssets.Add("Assets/gruvbox_light_soft.css");
        OtherAssets.Add("Assets/solarized_dark.css");
    }

    public override void OnInit()
    {
        Logs.Init("MoreThemes Extension initializing...");
        Program.Web.RegisterTheme(new("ctp_mocha_bg", "Catppuccin Mocha [Fancy] (MoreThemes)", ["css/themes/modern.css", "/ExtensionFile/MoreThemes/Assets/ctp_background.css", "css/themes/ctp_mocha.css"], true));
        Program.Web.RegisterTheme(new("ctp_macchiato_bg", "Catppuccin Macchiato [Fancy] (MoreThemes)", ["css/themes/modern.css", "/ExtensionFile/MoreThemes/Assets/ctp_background.css", "css/themes/ctp_macchiato.css"], true));
        Program.Web.RegisterTheme(new("ctp_frappe_bg", "Catppuccin Frappé [Fancy] (MoreThemes)", ["css/themes/modern.css", "/ExtensionFile/MoreThemes/Assets/ctp_background.css", "css/themes/ctp_frappe.css"], true));
        Program.Web.RegisterTheme(new("ctp_latte_bg", "Catppuccin Latte [Fancy] (MoreThemes)", ["css/themes/modern.css", "/ExtensionFile/MoreThemes/Assets/ctp_background.css", "css/themes/ctp_latte.css"], false));
        Program.Web.RegisterTheme(new("nord_polar_night", "Nord Polar Night (MoreThemes)", ["css/themes/modern.css", "/ExtensionFile/MoreThemes/Assets/nord_polar_night.css"], true));
        Program.Web.RegisterTheme(new("nord_snow_storm", "Nord Snow Storm (MoreThemes)", ["css/themes/modern.css", "/ExtensionFile/MoreThemes/Assets/nord_snow_storm.css"], false));
        Program.Web.RegisterTheme(new("rose_pine", "Rosé Pine (MoreThemes)", ["css/themes/modern.css", "/ExtensionFile/MoreThemes/Assets/rose_pine.css"], true));
        Program.Web.RegisterTheme(new("rose_pine_moon", "Rosé Pine Moon (MoreThemes)", ["css/themes/modern.css", "/ExtensionFile/MoreThemes/Assets/rose_pine_moon.css"], true));
        Program.Web.RegisterTheme(new("rose_pine_dawn", "Rosé Pine Dawn (MoreThemes)", ["css/themes/modern.css", "/ExtensionFile/MoreThemes/Assets/rose_pine_dawn.css"], false));
        Program.Web.RegisterTheme(new("gruvbox_dark_hard", "gruvbox dark hard (MoreThemes)", ["css/themes/modern.css", "/ExtensionFile/MoreThemes/Assets/gruvbox_dark_hard.css"], true));
        Program.Web.RegisterTheme(new("gruvbox_dark", "gruvbox dark (MoreThemes)", ["css/themes/modern.css", "/ExtensionFile/MoreThemes/Assets/gruvbox_dark.css"], true));
        Program.Web.RegisterTheme(new("gruvbox_dark_soft", "gruvbox dark soft (MoreThemes)", ["css/themes/modern.css", "/ExtensionFile/MoreThemes/Assets/gruvbox_dark_soft.css"], true));
        Program.Web.RegisterTheme(new("gruvbox_light_hard", "gruvbox light hard (MoreThemes)", ["css/themes/modern.css", "/ExtensionFile/MoreThemes/Assets/gruvbox_light_hard.css"], false));
        Program.Web.RegisterTheme(new("gruvbox_light", "gruvbox light (MoreThemes)", ["css/themes/modern.css", "/ExtensionFile/MoreThemes/Assets/gruvbox_light.css"], false));
        Program.Web.RegisterTheme(new("gruvbox_light_soft", "gruvbox light soft (MoreThemes)", ["css/themes/modern.css", "/ExtensionFile/MoreThemes/Assets/gruvbox_light_soft.css"], false));
        Program.Web.RegisterTheme(new("solarized_dark", "Solarized Dark (MoreThemes)", ["css/themes/modern.css", "/ExtensionFile/MoreThemes/Assets/solarized_dark.css"], true));

        Logs.Init("MoreThemes Extension initialized successfully");
    }
}
