using UnityEngine;
using UnityEngine.InputSystem;

public class MaxwellMovement : MonoBehaviour
{
    public float speed = 3;
    public Vector2 carPos;

    public GameObject victoryCanvas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //player movement
        Vector2 newPos = transform.position;

        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            newPos.y += speed * Time.deltaTime;
        }
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            newPos.y -= speed * Time.deltaTime;
        }
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            newPos.x -= speed * Time.deltaTime;
        }
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            newPos.x += speed * Time.deltaTime;
        }

        transform.position = newPos;

        if (newPos.y > 3.5)
        {
            victoryCanvas.SetActive(true);
        }
        else
        {
            victoryCanvas.SetActive(false);
        }
    }
}
