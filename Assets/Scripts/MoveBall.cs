using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

public class MoveBall : MonoBehaviour
{
    [Range(1f, 5f)]
    public float speed;
    
    Rigidbody player;

    public AudioSource jumpSound;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        player.velocity = new Vector3(horizontal * speed, player.velocity.y, player.velocity.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.velocity = new Vector3(player.velocity.x, 5, player.velocity.z);
        }
    }

}
