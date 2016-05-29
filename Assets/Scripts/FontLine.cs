using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FontLine {
    public Vector3 Size { get; private set; }
    public GameObject Go { get; private set; }
    public List<Pixel> Pixels { get; private set; }

    private const float CharSeparation = 2f;

    public FontLine(string line, Pixel pixelPrefab) {
        // Instantiate GameObject
        var lineGo = new GameObject("T: " + line);
        Go = lineGo;

        // Add Chars
        var xOffset = 0f;
        var fontChars = line.Select(c => Font.GetFontChar(c));
        Pixels = new List<Pixel>();
        foreach (var fontChar in fontChars) {
            if (fontChar == null) continue;

            // Compute pixels positions
            var pixelPositions = fontChar.PixelsPositions.Select(p => p + Vector2.right * xOffset).ToList();
            xOffset += fontChar.Width + CharSeparation;
            foreach (var pixelPosition in pixelPositions) {
                // Instantiate and positionate Pixel
                var pixel = GameObject.Instantiate(pixelPrefab);
                pixel.transform.parent = lineGo.transform;
                pixel.transform.localScale = Vector3.zero;
                pixel.transform.localPosition = pixelPosition;
                Pixels.Add(pixel);
            }
        }

        // Set Size of Line
        Size = new Vector3(xOffset - CharSeparation, Font.Height);
    }
}