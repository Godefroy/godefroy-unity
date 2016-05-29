using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof (Button))]
public class LinkButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
    public string Url;
    public Texture2D CursorTexture;
    public Vector2 CursorHotSpot;

    public void OnPointerEnter(PointerEventData eventData) {
        Cursor.SetCursor(CursorTexture, CursorHotSpot, CursorMode.ForceSoftware);
    }

    public void OnPointerExit(PointerEventData eventData) {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    private void Awake() {
        var button = GetComponent<Button>();
        button.onClick.AddListener(() => {
            if (Url != "") {
                Application.OpenURL(Url);
            }
        });
    }
}