using TMPro;
using UnityEngine;

public class FallingLeaves : MonoBehaviour
{
    public SpriteRenderer sr;

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;

    public float currentLeaf = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentLeaf == 0)
        {
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
        currentLeaf--;

        if (currentLeaf == -1)
        {
            currentLeaf = 2;
        }
    }

    public void UArrowRight()
    {
        currentLeaf++;

        if (currentLeaf == 3)
        {
            currentLeaf = 0;
        }
    }
}
