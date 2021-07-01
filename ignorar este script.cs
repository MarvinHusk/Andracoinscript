using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Coincls : MonoBehaviour
{
    public static int coinsCount = 0;
    public AudioClip coin;
    private int niveles;

    // Start is called before the first frame update
    void Start()
    {
        //se cuentan las monedas 
        Coincls.coinsCount ++;
        niveles = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //si se recolecta la moneda
    public void OnDestroy()
    {
     // aScorce.PlayOneShot(coin);
      Coincls.coinsCount --;
      if (Coincls.coinsCount <= 0)
      {
          Debug.Log("el juego ha terminado, el andraca esta feliz");
          GameObject timer = GameObject.Find("GameTimer");
          Destroy(timer);
        //  GameObject[] fuegos = GameObject.FindGameObjectsWithTag("Fuego");
        // foreach(GameObject fuego in fuegos) {
        //    fuego.GetComponent<ParticleSystem>().Play();
        //  }
          SceneManager.LoadScene(niveles);
      }  
    }
    //metodo tocar moneda
    void OnTriggerEnter(Collider playercollider){

      Debug.Log("haz sido tocado por el andraca");
      AudioSource.PlayClipAtPoint(coin, this.gameObject.transform.position);
      if(playercollider.CompareTag("Player")) {
          Destroy(gameObject);         
      }
    }  
  
}