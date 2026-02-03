using UnityEngine;

public class Toggle : MonoBehaviour
{
    public void ToggleShape()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);

        //if (gameObject.activeInHierarchy == false)
        //{
        //    gameObject.SetActive(true);
        //}
        //else if (gameObject.activeInHierarchy == true)
        //{
        //    gameObject.SetActive(false);
        //}
    }
}
