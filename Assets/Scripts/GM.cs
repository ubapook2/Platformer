using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GM : MonoBehaviour {

    public int coins = 0;
    public int lives = 3;
    public int coinsNeeded = 4;
    public int health = 100;
    public int ammo = 5;


    public Text coinsText;
    public Text livesText;
    public Text healthText;
    public Text ammoText;

    public GameObject winSign;
    public GameObject outSign;
    public GameObject checkpointReached;

	// Use this for initialization
	void Start ()
    {
        coinsText.text = coins.ToString();
        livesText.text = lives.ToString();
        healthText.text = health.ToString();
        ammoText.text = ammo.ToString();
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void CoinWasPickedUp(int worth)
    {
        coins += worth;
        coinsText.text = coins.ToString();

        if (coins % 10 == 0)   // this part will make it so 10 coints grants 25 health
        {
            health += 25;
            healthText.text = health.ToString();
        }

    }

    public void heartPickedUp()
    {
        lives++;
        livesText.text = lives.ToString();
    }

    public void LifeWasLost()
    {
        lives--;
        livesText.text = lives.ToString();

        if (lives == 0)
        {
            outSign.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void loseHealth()    // this will be a way to keep track of health, starting at 100, -25 each hit with an enemy
    {
        health -= 25;
        healthText.text = health.ToString();

        if (health == 0)
        {
            FindObjectOfType<Player>().Die();
            health = 100;
            healthText.text = health.ToString();
        }
    }

    public void respawn() // respawns player with full health
    {
        health = 100;
        healthText.text = health.ToString();
    }

    //public void checkpoint()     // shows a sign that checkpoint has been reached
    //{
     //   checkpointReached.SetActive(true);
    //}

    public void youWin()   // Enables the "You Win" sign upon reaching the end of last level
    {
        winSign.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ammoUsed()
    {
        ammo--;
        ammoText.text = ammo.ToString();
    }

    public void ammoPickedUp()
    {
        ammo += 5;
        ammoText.text = ammo.ToString();
    }
}
