using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyBall : MonoBehaviour
{
    public AudioSource audio;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == GameObject.FindGameObjectWithTag("Player"))
        {
            audio.Play();
            Destroy(collision.gameObject);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
