using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class EvilMaxwell : MonoBehaviour
{
    public SpriteRenderer maxwell;
    public AudioClip deathSFX;

    public float health;
    public float maxHealth = 5;

    public Slider healthBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
        healthBar.maxValue = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if (maxwell.bounds.Contains(mousePos) == true && Mouse.current.leftButton.wasPressedThisFrame)
        {
            health -= 1;
            healthBar.value = health;

            //if (health <= 0 )
            //{
            //    //audioSource.PlayOneShot(deathSFX);
            //    Destroy(gameObject);
            //}

        }
    }
}
