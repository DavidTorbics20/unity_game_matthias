using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColissionDetection : MonoBehaviour
{
    public Transform player;
    public GameObject bullet;

    public int health = 3;
    public int numberOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Debug.Log(health);
            health -= 1;
            Debug.Log(health);
            if (health <= 0)
            {
                hearts[0].sprite = emptyHeart;
                Destroy(bullet.gameObject);
                Destroy(player.gameObject);
                this.gameObject.SetActive(false);
                this.gameObject.SetActive(false);
            }
        }
    }
    void Update()
    {
        if (health > numberOfHearts)
        {
            health = numberOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numberOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
