using UnityEngine;

public class bullet : MonoBehaviour
{
    public float time = 5f;
    public int damage = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        despawn();
    }

    void despawn()
    {
        time -= Time.deltaTime;

        if (time <= 0)
            Destroy(gameObject);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            Debug.Log("hit");
            Enemy enemy = other.gameObject.GetComponent<Enemy>();
            enemy.health -= damage;
            Destroy(gameObject);
        }
    }
}
