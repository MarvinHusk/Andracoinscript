using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rein : MonoBehaviour
{
    private int nivel;
    void Start()
    {
        nivel = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
             SceneManager.LoadScene(nivel); 
         }
    }
}
