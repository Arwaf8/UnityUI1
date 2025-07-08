using UnityEngine;

public class PointerMover : MonoBehaviour
{
    public RectTransform handPointer;         // «·Ìœ
    public Vector2 offset = new Vector2(-170f, 120f); //  Õ—ÌﬂÂ« Ì”«— «·“— „⁄ ÷»ÿ »”Ìÿ
    public float waveAmount = 5f;             // ﬂ„   Õ—ﬂ Ì„Ì‰ ÊÌ”«—
    public float waveSpeed = 3f;              // ”—⁄… «·Õ—ﬂ…

    private Vector2 basePosition;
    private bool initialized = false;

    public void MoveTo(RectTransform target)
    {
        if (handPointer != null && target != null)
        {
            basePosition = target.anchoredPosition + offset;
            handPointer.anchoredPosition = basePosition;
            initialized = true;
        }
    }

    void Update()
    {
        if (initialized)
        {
            float wave = Mathf.Sin(Time.time * waveSpeed) * waveAmount;
            handPointer.anchoredPosition = basePosition + new Vector2(wave, 0f);
        }
    }
}