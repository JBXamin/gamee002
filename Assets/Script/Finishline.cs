using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finishline : MonoBehaviour
{
    [SerializeField] ParticleSystem Finisheffect;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            Debug.Log("You Finished !! ");
            Finisheffect.Play();
            Invoke("Reload",2f);
        }
    }
    void Reload(){
        SceneManager.LoadScene(1);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
