using System;
using grayScale;
using UnityEngine;
using Random = UnityEngine.Random;

public class AsciiHevan : MonoBehaviour
{
 
    private const string brightnessString = "Ñ@#W$9876543210?!abc;:+=-,._ ";

    private string output;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ASCIIinate() {
        Color pixel = Color.white;
        float gray = Random.Range(0f, 1f);
        char N = brightnessString[1];
        int index = gray.Remap(0, 1, 0, brightnessString.Length - 1);
        char ASCIICHARCTER = brightnessString[index];
        output += $"<color=#{pixel.ConvertToHex()}>";
        
    }

    // Update is called once per frame

}
