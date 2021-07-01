using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puntos : MonoBehaviour
{
    int niveles;
    public AudioClip monedasound;

    int puntaje;

    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;
        niveles = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Andracoin")){

           other.gameObject.SetActive(false);
           AudioSource.PlayClipAtPoint(monedasound, this.gameObject.transform.position);
           puntaje = puntaje + 1;
           if(puntaje >= 20)
           {
                GameObject timer = GameObject.Find("GameTimer");
                Destroy(timer);
                SceneManager.LoadScene(niveles);
           }

        }
    }
}
