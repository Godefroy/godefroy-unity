using System.Collections;
using UnityEngine;

public class MouseEffector : MonoBehaviour {
    private void Update() {
        var mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0;
        transform.position = mouseWorldPosition;
    }

    private void OnCollisionEnter(Collision collision) {
        // Action on click only
        if (!Input.GetMouseButton(0)) return;

        var pixel = collision.rigidbody.GetComponent<Pixel>();
        if (!pixel || !pixel.JointEnabled) return;

        StartCoroutine(AnimatePixelCollision(pixel));
    }

    private IEnumerator AnimatePixelCollision(Pixel pixel) {
        // Make it fall
        pixel.Fall();

        yield return new WaitForSeconds(2f);

        // Joint again
        pixel.JointToPosition();
    }
}