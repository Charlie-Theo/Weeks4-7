using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Duckie : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //was the mouse pressed this frame? && mouse isnt over UI
        if (Mouse.current.leftButton.wasPressedThisFrame == true && EventSystem.current.IsPointerOverGameObject() == false)
        {
            //Y: move to that position
            Vector2 mousePos = Camera.main.ScreenToWorldPoint (Mouse.current.position.ReadValue());
            transform.position = mousePos;
        }
    }
}
