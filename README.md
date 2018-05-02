# Windows Auto Dark
A program that sets/toggles the Windows 10 dark theme. This can be done with
PowerShell, but it causes a window to show for a second. Running this program
won't show a window at all. This makes it particularly useful for changing the
theme automatically.

## Installation
Compile the program or download the executable from the Github releases page.
Place the executable anywhere that users can access it.

## Running
If the program is run without any arguments, then it will toggle the dark theme
setting. You can pass in one of two arguments: `light` or `dark`. Only the
first argument will be read in, all others will be ignored.

## Scheduling
Use Windows Task Scheduler to run this automatically.
[This article](https://www.windowscentral.com/how-automatically-switch-dark-mode-night-time-windows-10)
has detailed instructions on how to do so. Just use the path to this program's
executable in place of the path to PowerShell and `light` or `dark` in place of
the PowerShell arguments.
