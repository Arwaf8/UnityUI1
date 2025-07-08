using UnityEngine;

public class IntroWave : MonoBehaviour
{
    public float amplitude = 2f;
    public float speed = 2f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.localPosition;
    }

    void Update()
    {
        float wave = Mathf.Sin(Time.time * speed) * amplitude;
        transform.localPosition = startPos + new Vector3(0, wave, 0);
    }
}