using UnityEngine;

public class Boom : Bird
{
    public Animator anim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstacle" || collision.gameObject.tag == "Enemy")
        {
            Destroy(GameObject.FindGameObjectWithTag("Obstacle"));
            anim.SetBool("isBoom", true);
            Delay();
        }
    }

    void Destroy()
    {
        Destroy(gameObject);
    }

    void Delay()
    {
        Invoke("Destroy", 1);
    }
}