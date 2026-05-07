global using Windows.UI.ViewManagement;
global using Windows.UI.ViewManagement.Core;

int preferredTextScale;

// I want to pass in the preferred text scale factor (int between 100 and
// 225) as a command line arg.
// If that number is out of range, not provided, can't be parsed as an int,
// or there are too many args (should be only the one single number); show an
// error message. (Preferrably as a popup window, if I can do that.)
if (args.Length != 1)
{
    Console.Error.WriteLine("The ToggleTextScale command must include EXACTLY one (1) command line argument: the preferred text scale.");
    return;
}
if (!int.TryParse(args[0], out preferredTextScale))
{
    Console.Error.WriteLine("The preferred text scale passed into the ToggleTextScale command must be an integer between 100 (inclusive) and 225 (inclusive).");
    return;
}
if (preferredTextScale < 100 ||  preferredTextScale > 225)
{
    Console.Error.WriteLine("The preferred text scale passed into the ToggleTextScale command must be an integer between 100 (inclusive) and 225 (inclusive).");
    return;
}

// Creating some objects that I will need.
UISettings uISettings = new();
UISettingsController uISettingsController = await UISettingsController.RequestDefaultAsync();
// If the current TextScaleFactor == 100, set it to the preferred value.
// (Turns out I actually need to work with a double that goes from 1 to 2.25
// and not an int that goes from 100 to 225 like I expected, but oh well.)
if (uISettings.TextScaleFactor == 1)
    uISettingsController.SetTextScaleFactor((double)preferredTextScale / 100);
// Otherwise, set it to 100.
else uISettingsController.SetTextScaleFactor(1);
