using UnityEngine;
public class Player : MonoBehaviour
{
    public Rigidbody self;
    public float speed;
    public int health;
    public int damage;
    public GameObject bullet;
    public float fireRate = 0.2f;
    private float fireTimer;
    private Vector3 moveInput;

    void Update()
    {
        shoot(); 
    }
    void FixedUpdate()
    {
        movement();
        
    }


    void shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBullet = Instantiate(bullet, self.position + transform.forward, self.rotation);

            Rigidbody rb = newBullet.GetComponent<Rigidbody>();
            rb.linearVelocity = transform.forward * 25f;
        }
    }

    void movement()
    {
        Vector3 moveInput = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            moveInput += Camera.main.transform.forward;

        if (Input.GetKey(KeyCode.S))
            moveInput -= Camera.main.transform.forward;

        if (Input.GetKey(KeyCode.D))
            moveInput += Camera.main.transform.right;

        if (Input.GetKey(KeyCode.A))
            moveInput -= Camera.main.transform.right;

        moveInput.y = 0;
        moveInput.Normalize();

        Vector3 velocity = moveInput * speed;
        velocity.y = self.linearVelocity.y;

        self.linearVelocity = velocity;
    }
}