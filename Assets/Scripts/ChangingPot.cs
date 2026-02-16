using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangingPot : MonoBehaviour
{
    SpriteRenderer sr;
    public TextMeshProUGUI potText;

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;

    float currentPot = 0; //is used for the code to determine which pot is currently being displayed

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //checks which pot is being displayed
        if (currentPot == 0)
        {
            //changes the sprite and text to represent the corrosponding pot
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
        //when this function is called, -1 from the current pot variable, which changes the pot to a new one
        currentPot--;

        //checks if the pot variable is going beyond the minimum pot option
        if (currentPot == -1)
        {
            //cycles back to the top pot option
            currentPot = 2;
        }
    }

    public void UArrowRight()
    {
        //when this function is called, +1 from the current pot variable, which changes the pot to a new one
        currentPot++;

        //checks if the pot variable is going beyond the maximum pot option
        if (currentPot == 3)
        {
            //cycles back to the bottom pot option
            currentPot = 0;
        }
    }
}
