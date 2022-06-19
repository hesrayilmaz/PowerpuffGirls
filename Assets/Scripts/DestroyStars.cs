using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyStars : MonoBehaviour
{
    public ParticleSystem ps;
    public SpriteRenderer sr;
    public bool once = true;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        if(collision.tag == "Player" )
        {
            ScoreManager.score++;
            var em = ps.emission;
            var dur = ps.duration;
            
            em.enabled = true;
            ps.Play();

            
            Destroy(sr);
            Invoke(nameof(DestroyObj), dur);
            
        }
/*
        if (collision.tag == "Player" )
        {  
            Destroy(this.gameObject);
            ScoreManager.score++;
        }
*/
    }

    void DestroyObj()
    {
        Destroy(this.gameObject);
    }
}
