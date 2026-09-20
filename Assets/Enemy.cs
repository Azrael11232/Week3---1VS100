
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform location;
    public Transform player;
    public GameObject self;
    public Rigidbody rb;
    public int count;
    public int health = 100;
    public int speed;
    public int damage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        health = 100/count;
        speed = speed + count/10;

        Debug.Log(gameObject.name + " health = " + health);

    }

    // Update is called once per frame
    void Update()
    {
        follow();
        split();
    }



    void follow()
    {
        Vector3 direction = (player.position - transform.position).normalized;

        rb.linearVelocity = direction * speed;
    }

    bool dead = false;

    void split()
    {
        if (health <= 0 && !dead)
        {
            dead = true;

            Instantiate(self, transform.position + Vector3.right, transform.rotation);
            Instantiate(self, transform.position + Vector3.left, transform.rotation);

            count += 1;

            Destroy(gameObject);
        }
    }
}
