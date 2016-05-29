using System.Collections.Generic;
using UnityEngine;

public class FontChar {
    public int Width { get; private set; }
    public int Height { get; private set; }
    public List<Vector2> PixelsPositions { get; private set; }

    private FontChar() {
    }

    public FontChar(int width, int height, List<Vector2> pixelsPositions) {
        Width = width;
        Height = height;
        PixelsPositions = pixelsPositions;
    }
}