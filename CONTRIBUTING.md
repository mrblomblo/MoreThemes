# Contributing
So, you're not satisfied with the existing themes, huh? Well no problem, I will gladly take PRs!

> [!TIP]
> When editing the `MoreThemes.cs` file, don't forget to use the dev launch script, and restart SwarmUI after your edits to make sure they are properly applied!

## Creating a New Theme
> [!NOTE]
> Just to prefix; I am not good with licenses and that kind of stuff, but try to stick to color palettes/themes with the MIT license. When creating a PR, you are expected to provide proof of which license the color palette has (such as a link to the official Git repo).

When creating a new theme, do the following:
1. Add a new `Program.Web.RegisterTheme` line to `MoreThemes.cs`.  
    - The first parameter is the theme's ID, which should in most cases match the filename you give the CSS file (excluding the ".css").
    
    - The second parameter is the user-facing name for the theme. "(MoreThemes)" should always be added to the end of the theme name.

    - The third parameter should look like the following: `["css/themes/modern.css", "/ExtensionFile/MoreThemes/Assets/<filename>"]`, where "\<filename\>" is the theme's filename (followed by ".css"). Themes not using `modern.css` will not be accepted.

    - The fourth and last parameter is a bool (true/false) for if the theme is a dark-mode theme. It should be `true` for dark themes, and `false` for light themes.

2. Add a new `OtherAssets.Add` line to `MoreThemes.cs`. Just copy one of the existing ones and replace the filename with the filename for your new theme.

3. Create a new css file for the theme in the `Assets` folder.

After that, you should decide if you want to create a more in-depth theme that themes more of SwarmUI, or if you want to create a theme that themes most portions, but isn't as in-depth. It's basically like a fill-in-the-blanks.

You should follow one of these templates:

<details>
<summary>In-depth theming template</summary>

```css
:root {
    --background: ;
    --background-soft: ;
    --background-gray: ;
    --background-panel: ;
    --background-panel-subtle: ;

    --background-danger: ;
    --background-gray-danger: ;

    --text: ;
    --text-soft: ;
    --text-strong: ;

    --button-text: ;
    --button-foreground-hover: ;
    --button-foreground-disabled: ;
    --button-background: ;
    --button-background-disabled: ;
    --button-primary-text-color: ;
    --button-border: ;
    --basic-button-bg-color-disabled: ;

    --danger-button-border: ;
    --danger-button-foreground-hover: ;
    --danger-button-foreground: ;
    --danger-button-background-hover: ;
    --danger-button-background: ;

    --emphasis: ;
    --emphasis-soft: ;
    --emphasis-text: ;

    --border-color: ;
    --light-border: ;

    --status-bar-text-color: ;
    --status-bar-warn-color-start-end: ;
    --status-bar-warn-color-middle: ;
    --status-bar-error-color-start-end: ;
    --status-bar-error-color-middle: ;
    --status-bar-soft-color: ;

    --backend-errored-border-color: ;
    --backend-disabled-border-color: ;
    --backend-running-border-color: ;
    --backend-idle-border-color: ;
    --backend-loading-border-color: ;
    --backend-waiting-border-color: ;

    --backend-errored: ;
    --backend-disabled: ;
    --backend-running: ;
    --backend-idle: ;
    --backend-loading: ;
    --backend-waiting: ;

    --range-track-background: ;
    --range-track-color: ;
    --range-thumb-color: ;
    --slider-toggle-background: ;
    --slider-toggle-thumb-color: ;
    --toggle-background: ;
    --toggle-thumb-active: ;
    --toggle-thumb-color: ;

    --model-img-border-color-hover: ;
    --model-block-menu-button-border-color-hover: ;
    --model-block-menu-button-color-hover: ;

    --popup-front: ;
    --notice-pop: ;
    --toast-header: ;
    --toast-body: ;

    --batch-0: ;
    --batch-1: ;

    --red: ;
    --green: ;
    --yellow: ;
    --white: ;
    --black: ;
    --star: ;
    --gray: ;
    --darkgray: ;

    --transparentdarkred: ;
    --scrollbar: ;
    --shadow: ;
}
```

</details>

<details>
<summary>Simpler theming template</summary>

From [Modern Dark](https://github.com/mcmonkeyprojects/SwarmUI/blob/master/src/wwwroot/css/themes/modern_dark.css)

```css
:root {
    --background-soft: ;
    --background-gray: ;
    --background-gray-danger: ;
    --shadow: ;
    --light-border: ;
    --popup-front: ;
    --button-foreground-disabled: ;
    --text-soft: ;
    --background: ;
    --text: ;
    --text-strong: ;
    --emphasis: ;
    --emphasis-soft: ;
    --button-text: ;
    --background-panel: ;
    --background-panel-subtle: ;
    --emphasis-text: ;
    --border-color: ;
    --button-background: ;
    --range-track-color: ;
    --range-thumb-color: ;
}
```

Since this template only themes what I would call the bare minimum, you are free to add more things to it. Just be sure to have a newline separating the vars from the template and the vars you've added, like the following:

```css
:root {
    --range-thumb-color: ; /* last var from the template */

    --your-var-here: ;
    --your-other-var-here: ;
    /* et cetera */
}
```

</details>

You should also probably look at existing themes for ideas of which colors are better for different things. Don't forget to include a newline at the end of the file!

When creating your PR, you should include at least one screenshot. Preferably one of the Generate tab, as it has many different elements, and will showcase your theme well.

**Why do I have to use a template?**  
Because it makes it much easier for me to maintain!

## Updating an existing theme
Edit the CSS file for the theme you want to improve. Do **NOT** change any theme IDs in `MoreThemes.cs` (the first param after `RegisterTheme(new(`, for example "nord_polar_night"), as that will make it so users that are using that theme need to re-select the theme.

When creating the PR for the theme you want to update, explain why you made the changes you made, and be sure to include screenshots highlighting the differences between the original and the updated version.

If you are adding or removing a variable from a theme, you should update all other themes that follow that theme's template accordingly and with appropriate colors. 
