using UnityEngine;

public class PointerMover : MonoBehaviour
{
    public RectTransform handPointer;         // ����
    public Vector2 offset = new Vector2(-170f, 120f); // ������� ���� ���� �� ��� ����
    public float waveAmount = 5f;             // �� ����� ���� �����
    public float waveSpeed = 3f;              // ���� ������

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