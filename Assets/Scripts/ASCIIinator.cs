using System;
using grayScale;
using UnityEngine;
using Random = UnityEngine.Random;

 


public class ASCIIinator : MonoBehaviour

{
    public SpriteRenderer spriteRenderer; 
    
    private const string brightnessString = "Ñ@#W$9876543210?!abc;:+=-,._ ";
    
    private string output;
    void Start()
    {
    
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }
    public void ASCIIinate() {
        Color pixel = Color.white;
        float gray = Random.Range(0f, 1f);
        char N = brightnessString[1];
        int index = gray.Remap(0, 1, 0, brightnessString.Length - 1);
        char ASCIICHARCTER = brightnessString[index];
        output += $"<color=#{pixel.ConvertToHex()}>";
    }
    
}
