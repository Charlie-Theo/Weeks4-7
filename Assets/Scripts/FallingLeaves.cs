using TMPro;
using UnityEngine;

public class FallingLeaves : MonoBehaviour
{
    public SpriteRenderer sr;

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;

    public float currentLeaf = 0; //is used for the code to determine which leaf colour is currently being displayed

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //checks which leaf is being displayed
        if (currentLeaf == 0)
        {
            //changes the sprite to represent the corrosponding leaf
            sr.sprite = sprite1;
        }
        else if (currentLeaf == 1)
        {
            sr.sprite = sprite2;
        }
        else if (currentLeaf == 2)
        {
            sr.sprite = sprite3;
        }
    }

    public void UIArrowLeft()
    {
        //when this function is called, -1 from the current leaf variable, which changes the leaf to a new one
        currentLeaf--;

        //checks if the leaf variable is going beyond the minimum leaf option
        if (currentLeaf == -1)
        {
            //cycles back to the top leaf option
            currentLeaf = 2;
        }
    }

    public void UArrowRight()
    {
        //when this function is called, +1 from the current leaf variable, which changes the leaf to a new one
        currentLeaf++;

        //checks if the leaf variable is going beyond the maximum leaf option
        if (currentLeaf == 3)
        {
            //cycles back to the bottom leaf option
            currentLeaf = 0;
        }
    }
}
