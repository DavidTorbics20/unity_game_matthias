using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    
    public Transform player;
    public float speed = 5.0f;
    //public float repelRange = 2.0f;
    //public Vector2 repelForce = Vector2.zero;

    private Rigidbody2D rb;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }
    private void OnTriggerEnter2D(Collider2D collision) //or OnCollisionEnter2D
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            Debug.Log("enemy hit!");
            Destroy(collision.gameObject);
            Destroy(gameObject);
            this.gameObject.SetActive(false);
            Score.scoreValue += 10;
        }
    }
    //private void OnTriggerEnter2D(Collider2D Enemy1)
    //{
    //    Debug.Log("enemy hit!");
    //    enemy1maxhp -= 1;
    //    if (enemy1maxhp == 0)
    //    {
    //        Destroy(Enemy1.gameObject);
    //        this.gameObject.SetActive(false);
    //    }
    //}

    //void repelEnemy()
    //{
    //    foreach (Transform enemy in Enemy1)
    //    {
    //        if (Vector2.Distance(enemy.position, rb.position) <= repelRange)
    //        {
    //            repelForce += (rb.position - (Vector2)enemy.position).normalized;
    //        }
    //    }
    //}
}
