using TMPro;
using UnityEditor;
using UnityEngine;

public class GrowingPlant : MonoBehaviour
{
    SpriteRenderer sr;
    public TextMeshProUGUI plantText;

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;

    public float plantGrowth = 0; //the current size of the plant
    float currentPlant = 0; //is used for the code to determine which plant colour is currently being displayed

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //checks which plant is being displayed
        if (currentPlant == 0)
        {
            //changes the sprite and text to represent the corrosponding plant
            sr.sprite = sprite1;
            plantText.text = "Current Plant: Green";
        }
        else if (currentPlant == 1)
        {
            sr.sprite = sprite2;
            plantText.text = "Current Plant: Orange";
        }
        else if (currentPlant == 2)
        {
            sr.sprite = sprite3;
            plantText.text = "Current Plant: Blue";
        }
    }

    public void grow()
    {
        //checks of the size of the plant has hit the maximum size
        if (plantGrowth < 0.3)
        {
            //Y: increases the size of the plant
            plantGrowth += 0.03f;
        }
        //N: keeps the plant at the maximum size (does nothing)

        //updates the scale of the plant object to the new scale
        Vector2 plantSize;
        plantSize.x = plantGrowth;
        plantSize.y = plantGrowth;

        transform.localScale = plantSize;
    }

    public void resetPlant()
    {
        //sets the scale of the plant to 0
        plantGrowth = 0;

        //updates the scale of the plant object to the new scale
        Vector2 plantSize;
        plantSize.x = plantGrowth;
        plantSize.y = plantGrowth;

        transform.localScale = plantSize;
    }

    public void UIArrowLeft()
    {
        //when this function is called, -1 from the current plant variable, which changes the plant to a new one
        currentPlant--;

        //checks if the plant variable is going beyond the minimum plant option
        if (currentPlant == -1)
        {
            //cycles back to the top plant option
            currentPlant = 2;
        }
    }

    public void UArrowRight()
    {
        //when this function is called, +1 from the current plant variable, which changes the plant to a new one
        currentPlant++;

        //checks if the plant variable is going beyond the maximum plant option
        if (currentPlant == 3)
        {
            //cycles back to the bottom plant option
            currentPlant = 0;
        }
    }
}
