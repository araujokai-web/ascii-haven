using UnityEngine;

namespace grayScale
{
    public static class Extensions
    {
        public static int Remap (this float value, float from1, float to1, float from2, float to2) {
            return Mathf.RoundToInt((value - from1) / (to1 - from1) * (to2 - from2) + from2);
        }
        public static string ConvertToHex(this Color color)
        {
            string output = "";
            output += ((int)(color.r * 255)).ToString("X2");
            output += ((int)(color.g * 255)).ToString("X2");
            output += ((int)(color.b * 255)).ToString("X2");
            return  output;
        }
    }
}
