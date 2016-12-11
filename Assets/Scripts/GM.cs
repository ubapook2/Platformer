using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GM : MonoBehaviour {

    public int coins = 0;
    public int lives = 3;
    public int coinsNeeded = 4;
    public int health = 100;

    public Text coinsText;
    public Text livesText;
    public Text healthText;

    public GameObject winSign;
    public GameObject outSign;

	// Use this for initialization
	void Start ()
    {
        coinsText.text = coins.ToString();
        livesText.text = lives.ToString();
        healthText.text = health.ToString();
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void CoinWasPickedUp(int worth)
    {
        coins += worth;
        coinsText.text = coins.ToString();

        //if (coins == coinsNeeded)
        //{
        //    winSign.SetActive(true);
        //}
    }

    public void LifeWasLost()
    {
        lives--;
        livesText.text = lives.ToString();

        if (lives == 0)
        {
            outSign.SetActive(true);
        }
    }

    public void loseHealth()
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
}
