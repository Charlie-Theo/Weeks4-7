using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public SpriteRenderer player;

    public int health = 5;

    public AudioSource audioSource;
    public AudioClip chompSFX;
    public AudioClip deathSFX;

    //audioSource.Play() plays the current clip in audioSource.clip and stops/restarts it
    //audioSource.PlayOneShot(MyClip) plays MyClip and will play on top of a currently playing (on this Audio Source) clip

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthBar.maxValue = health;
        healthBar.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        //get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //is inside sprite and are clicking button?
        if (player.bounds.Contains(mousePos) == true && Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            //Y: take 1 off health
            health -= 1;
            audioSource.Play();
            if (health <= 0)
            {
                //set SFX to death
                //play SFX
                //audioSource.clip = deathSFX;
                //audioSource.Play();
                audioSource.PlayOneShot(deathSFX);
                gameObject.SetActive(false);
            }
            else
            {
                //set dmg SFX
                //play SFX
                audioSource.clip = chompSFX;
                audioSource.Play();
            }
        }

        //update the health bar with new value
        healthBar.value = health;
    }

    public void Heal()
    {
        //turn on player game object
        gameObject.SetActive (true);

        //set health back to 5
        health = (int) healthBar.maxValue;

        //set the value of the slider to our health
        healthBar.value = health;
    } 
}
