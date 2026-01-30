using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public Color col;

    //public Sprite [] barrels;
    public List <Sprite> barrels;

    public int randomNum;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //PickARandomColour();
        PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            Debug.Log("Try to change the sprite please");
            //PickARandomColour();

            if (barrels.Count > 0 )
            {
                PickARandomSprite();
            }
        }


        //Get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //Check if mouse is over the shape
        if (spriteRenderer.bounds.Contains(mousePos) == true)
        {
            //Y: Set colour (col) variabe
            spriteRenderer.color = col;
        }
        else
        {
            //N: Set colour white
            spriteRenderer.color = Color.yellow;
        }

        if (Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count > 0)
        {
            barrels.RemoveAt(0);
        }
    }

    void PickARandomColour ()
    {
        spriteRenderer.color = Random.ColorHSV();
    }

    void PickARandomSprite()
    {
        //spriteRenderer.sprite = mySprite;

        //pick a random number
        //randomNum = Random.Range(0, barrels.Length);
        randomNum = Random.Range(0, barrels.Count);

        //use that number to choose sprite
        //if(randomNum == 0)
        //{
        //    spriteRenderer.sprite = barrel0;
        //} 
        //else if (randomNum == 1)
        //{
        //    spriteRenderer.sprite = barrel1;
        //} 
        //else if (randomNum == 2)
        //{
        //    spriteRenderer.sprite = barrel2;
        //}

        spriteRenderer.sprite = barrels[randomNum];

        //assign sprite to sprite renderer
    }
}
