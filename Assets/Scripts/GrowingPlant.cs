using TMPro;
using UnityEditor;
using UnityEngine;

public class GrowingPlant : MonoBehaviour
{
    public SpriteRenderer sr;
    //public TextMeshProUGUI plantText;

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;

    public float plantGrowth = 0;
    float currentPlant = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        plantGrowth = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPlant == 0)
        {
            sr.sprite = sprite1;
            //plantText.text = "Current Plant: Green";
        }
        else if (currentPlant == 1)
        {
            sr.sprite = sprite2;
            //plantText.text = "Current Plant: Orange";
        }
        else if (currentPlant == 2)
        {
            sr.sprite = sprite3;
            //plantText.text = "Current Plant: Blue";
        }
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
