using UnityEngine;
using System.Collections;


public class notes : MonoBehaviour

{
    public string myName = " none";

    void Start()
    {
        Debug.Log("this is not a machine " + myName);
    }
}//maybe texture2D because he is trying to get the information out 
//Color pixel = spriteRenderer.GetPixels(0, 0, 1, 1); //maybe texture 2D but .image does not make sense
//float gray = pixel.r * 0.299f + pixel.g * 0.587f + pixel.b * 0.114f;        
//Color grayScalePixel = new Color(pixel.r, pixel.g, pixel.b, gray);