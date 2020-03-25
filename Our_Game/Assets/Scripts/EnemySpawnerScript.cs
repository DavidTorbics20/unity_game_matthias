using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;

    public float spawnrate;
    public float pointstowin;

    float nextspawn = 0.0f;
    float randX;
    float randY;
    float counter = 0;

    Vector2 wheretospawn;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 0 && Time.time > nextspawn)
        {
            Debug.Log("enemy1 spawn");

            nextspawn = Time.time + spawnrate;
            randX = Random.Range(-100, 100);
            randY = Random.Range(-100, 100);
            wheretospawn = new Vector3(randX, randY, transform.position.y);
            Instantiate(Enemy1, wheretospawn, Quaternion.identity);
            counter += 1;
        }
        if (counter == 1 && Time.time > nextspawn)
        {
            Debug.Log("enemy2 spawn");

            nextspawn = Time.time + spawnrate;
            randX = Random.Range(-100, 100);
            randY = Random.Range(-100, 100);
            wheretospawn = new Vector3(randX, randY, transform.position.y);
            Instantiate(Enemy2, wheretospawn, Quaternion.identity);
            counter += 1;
        }
        if (counter == 2 && Time.time > nextspawn)
        {
            Debug.Log("enemy3 spawn");

            nextspawn = Time.time + spawnrate;
            randX = Random.Range(-100, 100);
            randY = Random.Range(-100, 100);
            wheretospawn = new Vector3(randX, randY, transform.position.y);
            Instantiate(Enemy3, wheretospawn, Quaternion.identity);
            counter += 1;
        }
        if (counter == 3 && Time.time > nextspawn)
        {
            Debug.Log("enemy4 spawn");

            nextspawn = Time.time + spawnrate;
            randX = Random.Range(-100, 100);
            randY = Random.Range(-100, 100);
            wheretospawn = new Vector3(randX, randY, transform.position.y);
            Instantiate(Enemy4, wheretospawn, Quaternion.identity);
            counter += 1;
        }
        if (counter == 4 && Time.time > nextspawn)
        {
            Debug.Log("enemy5 spawn");

            nextspawn = Time.time + spawnrate;
            randX = Random.Range(-100, 100);
            randY = Random.Range(-100, 100);
            wheretospawn = new Vector3(randX, randY, transform.position.y);
            Instantiate(Enemy5, wheretospawn, Quaternion.identity);
            counter -= 4;
            if (spawnrate > 1)
            {
                spawnrate -= 1;
            }
        }
    }
}
