using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedPowerUp : MonoBehaviour
{
    public GameObject speedpupbox;
    public float spawnrate;

    public int speedpic;
    public int maxspeedpic;

    public Image[] powerups;
    public Sprite fullpower;
    public Sprite emptypower;
    
    float nextspawn = 0.0f;
    float randX;
    float randY;

    Vector2 boxspawn;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextspawn)
        {
            Debug.Log("speed appear");

            nextspawn = Time.time + spawnrate;
            randX = Random.Range(-100, 100);
            randY = Random.Range(-100, 100);
            boxspawn = new Vector3(randX, randY, transform.position.y);
            Instantiate(speedpupbox, boxspawn, Quaternion.identity);
        }

        if (speedpic > maxspeedpic)
        {
            speedpic = maxspeedpic;
        }
        for (int i = 0; i < powerups.Length; i++)
        {
            if (i < speedpic)
            {
                powerups[i].sprite = fullpower;
            }
            else
            {
                powerups[i].sprite = emptypower;
            }


        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("BulletSpeed"))
        {
            Destroy(speedpupbox); 
            speedpupbox.gameObject.SetActive(false);
            speedpic += 1;
            if (SpeedScore.speedscore < 40)
            {
                SpeedScore.speedscore += 5.0f;
                MouseFollow.bulletspeed += 5.0f;
            }
        }
    }
}
