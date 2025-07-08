
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class UIButtonHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Header("UI Elements")]
    public Image background;
    public Image outline;
    public TMP_Text label;

    [Header("Hand Pointer")]
    public RectTransform handPointer;
    public Vector3 handOffset = new Vector3(-100f, 0f, 0f);

    [Header("Colors")]
    public Color normalTextColor = Color.black;
    public Color hoverTextColor = new Color(1f, 0.5f, 0f);

    public Color normalOutlineColor = Color.gray;
    public Color hoverOutlineColor = new Color(1f, 0.5f, 0f);

    public UIButtonHoverEffect()
    {
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (label != null)
            label.color = hoverTextColor;

        if (outline != null)
            outline.color = hoverOutlineColor;

        if (handPointer != null)
        {
            handPointer.gameObject.SetActive(true);
            handPointer.position = transform.position + handOffset;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (label != null)
            label.color = normalTextColor;

        if (outline != null)
            outline.color = normalOutlineColor;
    }
}
