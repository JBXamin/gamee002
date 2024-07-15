using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertorque : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float torquee = 1.5f;
    [SerializeField] ParticleSystem crasheffect;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb2d.AddTorque(torquee);
        }else if(Input.GetKey(KeyCode.RightArrow)){
            rb2d.AddTorque(-torquee);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            crasheffect.Play();
        }else crasheffect.Pause();
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "ground") crasheffect.Pause();
        else crasheffect.Play();
    }
}
