using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangingPot : MonoBehaviour
{
    public SpriteRenderer sr;
    public TextMeshProUGUI potText;

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;

    float currentPot = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPot == 0)
        {
            sr.sprite = sprite1;
            potText.text = "Current Pot: Brown";
        }
        else if (currentPot == 1)
        {
            sr.sprite = sprite2;
            potText.text = "Current Pot: Purple";
        }
        else if (currentPot == 2)
        {
            sr.sprite = sprite3;
            potText.text = "Current Pot: Green";
        }
    }

    public void UIArrowLeft()
    {
        currentPot--;

        if (currentPot == -1)
        {
            currentPot = 2;
        }
    }

    public void UArrowRight()
    {
        currentPot++;

        if (currentPot == 3)
        {
            currentPot = 0;
        }
    }
}
