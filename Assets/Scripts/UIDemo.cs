using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UIDemo : MonoBehaviour
{
    SpriteRenderer sr;//the square in the sprite world
    public Image duckieImage; //the duckie IMAGE on the UI canvas
    public int howManyClicks = 0;
    public TextMeshProUGUI score;
    public Slider slider;
    public TextMeshProUGUI sliderDisplay;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        score.text = howManyClicks.ToString();

        slider.wholeNumbers = true;
    }

    // Update is called once per frame
    void Update()
    {
        sliderDisplay.text = slider.value.ToString();

        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            changeColour();
        }
    }

    public void changeColour()
    {
        sr.color = Random.ColorHSV();
        duckieImage.color = sr.color;
    }

    public void setScale(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }

    public void AddToTheNumber()
    {
        howManyClicks++;
        score.text = howManyClicks.ToString();
    }
}
