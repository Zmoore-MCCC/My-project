using System.Collections.Generic;
using UnityEngine;



//=============================================================================
//setup: place one image as the first child of this gameobject
//       at runtime, two copies are created (left and right)
//optional single image mode: used for unique images that do not need to be repeated
//===================================================================================
public class SimpleParallax : MonoBehaviour
{
    private Vector2 parallaxSpeed;
    private float imageOverlap;
    private bool oneImage;
    //ability to keep track of all images needed to parallax
    private List<Transform> imageTransforms = new();
    //width of a sprite after accounting for overlap
    private float imageDistance;
    //reference to camera
    private Transform cameraTransform;
    //camera position during the previous frame
    //used to calculate how far the camera moved
    private Vector2 lastComPos;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
