using UnityEngine;

public class FunnySprites : MonoBehaviour
{
    SpriteRenderer sr;

    public Sprite sprite1;
    public Sprite sprite2;

    public float t = 0;
    public bool isTimerRunning = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimerRunning == true)
        {
            t += Time.deltaTime;

            if (t > 0.5)
            {
                sr.color = Random.ColorHSV();
                t = 0;
            }
        }
    }

    public void FunSprite()
    {
        sr.sprite = sprite2;
        isTimerRunning = true;
    }

    public void NormalSprite()
    {
        sr.sprite = sprite1;
        isTimerRunning = false;
        sr.color = Color.white;
    }
}
