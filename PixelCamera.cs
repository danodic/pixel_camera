using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This is a pixel camera class to be used with Unity for 2d games. Attach this script to your camera and everything will
 * make sense once you start the game. The idea is to have a pixel-perfect camera when working at a reference resolution,
 * and have the proportinal scaling done right when resizing the screen.
 * 
 * When using this class it is recomended that you do all your element placement and resizing thru the code,
 * using the Scale and Pixel attributes.
 * 
 * This class works by having a reference screen size. So let's say you have a screen of 1920x1080 and you want an
 * element to be at 600x400. That means the position has to be (600f*PixelCamera.Pixel, 400*PixelCamera.Pixel).
 * 
 * As for sizing, you need to scale it using the Scale attribute. That will hold the proportion for each dimension.
 * Z will always be 0, so never use z as it is useless.
 * 
 * With this class, you can have dinamic-scaling scenes without issues, as far as positions are calculated using Pixel
 * as a basis and the elements are scaled using Scale.
 * 
 * 2018 - Danilo Guimaraes - danilo.guimaraes@outlook.com.br
 * https://github.com/danodic/pixel_camera
 **/
public class PixelCamera : MonoBehaviour
{

    // Will hold the camera object.
    private Camera camera;

    // The scale is used to resize sprites so they fit dinamic resolutions.
    public Vector3 Scale;

    // This is the size of a pixel in world coordinates. Use that to place elements in the screen.
    public float Pixel;

    // Those are the ortographic camera dimensions
    public float SizeX, SizeY;

    // This is the reference screen size
    public float ScreenRefSizeX = 1920;
    public float ScreenRefSizeY = 1080;

    // Use this for initialization
    void Start()
    {

        float SizeX, SizeY;
        float floatable = 100.0f;

        // Get the camera component
        camera = GetComponent<Camera>();

        // Sets the camera to the real size
        // Copied from here:
        // https://forum.unity.com/threads/pixel-perfect-2d-in-4-3.210497/#post-1513436
        camera.orthographicSize = Screen.height * camera.rect.height / floatable / 2.0f;

        // Get camera dimensions
        SizeY = camera.orthographicSize;
        SizeX = (16f / 9f) * camera.orthographicSize;

        // Position camera at 0.0
        camera.transform.position = new Vector3(SizeX, SizeY, -10f);

        // Set the scale proportion to fix the sprite size
        Scale = new Vector3((float)Screen.width / ScreenRefSizeX, (float)Screen.height / ScreenRefSizeY, 0f);

        // Set the pixel size
        Pixel = (float)(((double)this.camera.orthographicSize * 2d) / (int)ScreenRefSizeX);

        // Update attributes
        this.SizeX = SizeX;
        this.SizeY = SizeY;

    }
}
