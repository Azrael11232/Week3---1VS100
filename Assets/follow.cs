using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public int speed;

    void LateUpdate()
    {
        if (player == null)
            return;

        transform.position = player.position + player.rotation * offset;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");

        transform.Rotate(0, mouseX * speed, 0);

        player.rotation = transform.rotation;
    }
}
