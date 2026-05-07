# ToggleTextScale

## Why It Exists

I have a vision impairment, and like to keep Windows' "Text Scaling" setting ("Settings app > Accessibility > Text Size" on Windows 11) set to a high value. Unfortunately, this breaks a lot of apps and websites, including several that I use regularly, and I got tired of opening Settings, digging up the slider, and waiting for Windows to refresh every time I used one of those apps or websites.

So I made a little program that I can plug into something like AutoHotKey to let me do it with a single button. 😎

It's not up to my standards because I built it just for me to use on my own personal computer, but I still felt it was too useful not to share with the world. (The issues that I do want to fix are all in this repo's "Issues" tab.)

## How To Use It

1. Download the ZIP file in the repo. <https://github.com/testmaster217/ToggleTextScale/blob/main/ToggleTextScale.zip>
2. Unzip it somewhere where you will remember that it exists.
3. Have your automation program of choice (i.e. AutoHotKey) run this command: `C:\Path\To\ToggleTextScale.exe <preferred_val>`, where `C:\Path\To\ToggleTextScale.exe` is the path to the executable inside the file that you unzipped, and `<preferred_val>` is your preferred text scaling value. (Must be an integer between 100 and 225 (both inclusive).)

Upon running this command, the program will switch your text scaling to the given preferred value if it's at 100%, and will switch it to 100% if it's at anything else.

> [!IMPORTANT]
> You should use the SAME `<preferred_val>` whether you're switching from or to 100%. I have not tested what happens when you aren't consistent with this input.

## Important Notes and Warnings

- This program only works with Windows. Specifically, it targets the newest version that Visual Studio would let me choose. Currently, the minimum version is also set to the newest thing that Visual Studio would let me choose, but I want to find out how old I can set it at some point. (See also Issue #2.)
- It requires .NET 9.0. I may add support for more .NET versions upon request.
- Standard command line options to print help and version information (i.e. `/?`, `--help`, `-h`, `--version`, etc.) are not implemented.
- Updates are not guaranteed to happen beyond addressing existing issues listed in the "Issues" tab.
- Finally, I would like to apologize for having however many extra files due to using a .NET language to write this program. I imagien that if I was good enough with C++, I could have made it smaller.

## Contributing

Code contributions are not accepted, but if you have a feature request, bug report, or any other feedback, you can join or open a relevant discussion by going to this repo's "Discussions" tab.