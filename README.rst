========
Pianopad
========
:Author: Danilo Guimaraes
:Email: danilo.guimaraes@outlook.com.br

Pixel Camera is a solution to have consistent graphics 2d graphics in your Unity game.

Everyone who has tried to use 2d with Unity knows it is a bit annoying to get your 2d sprites to look right and crisp. This is because unity works with 3d world units and not pixels.
This 2d camera class does the following jobs:
- Provide a Pixel attribute that represents the size of a pixel in the 3d world.
- Provide a Scale attribute that can be used to scale the sprites accordingly to the size of the screen.
- Set the ortographic camera size to the right size so everything works properly.

Usage
-----
* Drop the PixelCamera.cs anywhere in your Unity project.
* Attach this script to your camera.
* Change your camera to Ortographic.
* At the PixelCamera.cs, change the variables ScreenRefSizeX and ScreenRefSizeY to their right size. This is expected to be the reference screen size.
* Throughout the code, resize elements using PixelCamera.Scale and position them using PixelCamera.Pixel
