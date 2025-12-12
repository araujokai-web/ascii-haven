using System;
using grayScale;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

 


public class ASCIIinator : MonoBehaviour

{
    public Sprite sprite;
    public TMP_InputField Textext;
    
    private const string brightnessString = "Ñ@#W$9876543210?!abc;:+=-,._ ";
    
    private string output;

    void Start()
    {
        Texture2D texture = sprite.texture;
        output = "";
        for (int y = texture.height-1; y > 0; y--)
        {
            for (int x = 0; x < texture.width; x++)
            {
                Color color = texture.GetPixel(x, y);
                float gray = color.r * 0.299f + color.g * 0.587f + color.b * 0.114f;
                int index = gray.Remap(0, 1, brightnessString.Length - 1, 0);
                output += brightnessString[index];
            }

            output += "\n";
        }

        Textext.text = output;

    Color [,] grayScalePixels = new Color[3, 3];
            
        
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
