using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crashdetector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        Invoke("Reload", 1f);
    }
    void Reload(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
