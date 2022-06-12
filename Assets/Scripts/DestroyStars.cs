using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyStars : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        if (collision.tag == "Player")
        {
            Destroy(this.gameObject);
            ScoreManager.score++;
        }

    }
}
