using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        Rigidbody player;
        float speed;


        public PlayerMovement(Rigidbody rb)
        {
            player = rb;
        }

        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public void PlayerMove(Vector3 direction)
        {
            Vector3 movement = direction * speed * Time.deltaTime;
            player.MovePosition(player.transform.position + movement);
        }

        public void PlayerJump()
        {
            float jumpForce = 10f; // Встановіть потрібну силу стрибка
            player.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        public void PlayerStop()
        {
            player.velocity = new Vector3(0f, player.velocity.y, 0f);
        }
    }
}

