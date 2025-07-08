using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonTextColor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI targetText;
    public Color hoverColor = Color.black;
    public Color normalColor = Color.gray;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (targetText != null)
            targetText.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (targetText != null)
            targetText.color = normalColor;
    }
}
