using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

public class MoveBall : MonoBehaviour
{
    [Range(1f, 5f)]
    public float speed;
    PlayerMovement player;

    public AudioSource jumpSound;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        player = new PlayerMovement(rb);
        player.Speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        if (Input.GetKey(KeyCode.D))
        {
            direction = new Vector3(horizontal, 0f, vertical);
            player.PlayerMove(direction);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            direction = new Vector3(horizontal, 0f, -vertical);
            player.PlayerMove(direction);
        }
        else player.PlayerStop();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.jumpSound = jumpSound;
            player.PlayerJump(); 
        }
    }

}
