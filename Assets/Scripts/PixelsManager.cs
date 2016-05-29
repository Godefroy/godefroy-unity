using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelsManager : MonoBehaviour {
    public Pixel PixelPrefab;

    private Vector3 _screenWorldSize;
    private List<Pixel> _pixels = new List<Pixel>();

    public Vector3 ScreenWorldSize {
        get {
            if (_screenWorldSize == default(Vector3)) {
                _screenWorldSize = new Vector3((float) Screen.width / Screen.height, 1) * Camera.main.orthographicSize * 2;
            }
            return _screenWorldSize;
        }
    }

    private void Awake() {
        Vector3 fontLineSize;
        var yOffset = 0f;

        // Firstname
        fontLineSize = AddFontLine("Godefroy", 0.2f, yOffset, 0.6f);
        yOffset -= fontLineSize.y;

        // Lastname
        yOffset -= fontLineSize.y * 0.5f;
        fontLineSize = AddFontLine("de Compreignac", 0.2f, yOffset, 0.6f);
        yOffset -= fontLineSize.y;

        // Center vertically
        transform.localPosition = new Vector3(transform.localPosition.x, -yOffset / 2);

        StartCoroutine(Animate());
    }

    private Vector3 AddFontLine(string line, float xPerc, float y, float widthPerc) {
        var fontLine = new FontLine(line, PixelPrefab);
        fontLine.Go.transform.parent = transform;

        // Compute scale and size
        fontLine.Go.transform.localScale = Vector3.one * ScreenWorldSize.x * widthPerc / fontLine.Size.x;
        var fontLineSize = Vector3.Scale(fontLine.Size, fontLine.Go.transform.localScale);

        // Set Position
        fontLine.Go.transform.localPosition = new Vector3(ScreenWorldSize.x * (xPerc - 0.5f), y);

        // Register pixels
        _pixels.AddRange(fontLine.Pixels);

        return fontLineSize;
    }

    private IEnumerator Animate() {
        // Set initial position
        foreach (var pixel in _pixels) {
            pixel.Target = pixel.transform.position;
            pixel.transform.position = Vector3.Scale(new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f)), ScreenWorldSize);
            StartCoroutine(pixel.AnimatePop());
            pixel.Fall();
            yield return new WaitForSeconds(0.01f);
        }

        // Get to font line position
        foreach (var pixel in _pixels) {
            pixel.JointToPosition();
            yield return new WaitForSeconds(0.03f);
        }
    }
}