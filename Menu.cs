using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    private int niveles;
    // Start is called before the first frame update
    void Start()
    {
      niveles = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nivelsiguiente(){
        SceneManager.LoadScene(niveles); 
    }
}
