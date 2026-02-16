using TMPro;
using UnityEditor;
using UnityEngine;

public class GrowingPlant : MonoBehaviour
{
    public SpriteRenderer sr;
    public TextMeshProUGUI plantText;

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;

    public float plantGrowth = 0;
    float currentPlant = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPlant == 0)
        {
            sr.sprite = sprite1;
            plantText.text = "Current Plant: Default";
        }
        else if (currentPlant == 1)
        {
            sr.sprite = sprite2;
            plantText.text = "Current Plant: Plant 2";
        }
        else if (currentPlant == 2)
        {
            sr.sprite = sprite3;
            plantText.text = "Current Plant: Plant 3";
        }
    }

    public void grow()
    {
        if (plantGrowth < 2)
        {
            plantGrowth += 0.1f;
        }

        Vector2 plantSize;
        plantSize.x = plantGrowth;
        plantSize.y = plantGrowth;

        transform.localScale = plantSize;
    }

    public void resetPlant()
    {
        plantGrowth = 0;

        Vector2 plantSize;
        plantSize.x = plantGrowth;
        plantSize.y = plantGrowth;

        transform.localScale = plantSize;
    }

    public void UIArrowLeft()
    {
        currentPlant--;

        if (currentPlant == -1)
        {
            currentPlant = 2;
        }
    }

    public void UArrowRight()
    {
        currentPlant++;

        if (currentPlant == 3)
        {
            currentPlant = 0;
        }
    }
}
