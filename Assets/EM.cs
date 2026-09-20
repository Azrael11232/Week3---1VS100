using UnityEngine;

public class EM : MonoBehaviour
{
    public Transform player;
    public GameObject self;

    void Start()
    {
        Instantiate(self, player.position + player.forward * 20f, player.rotation);
    }

    void Update()
    {
        
    }
}