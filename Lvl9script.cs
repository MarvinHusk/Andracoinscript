using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvl9script : MonoBehaviour
{
    // Start is called before the first frame update
  public GameObject jugador, sex, sex2, target;


    bool activado = false;

    GameObject pisa1, pisa2;
    bool activado2 = false;
    public AudioClip sfx;

    public void Start() {
      pisa1 = GameObject.FindGameObjectWithTag("pizza1");
      pisa2 = GameObject.FindGameObjectWithTag("pizza2");
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("pizza1"))
        {
          sex.gameObject.SetActive(false);
          other.gameObject.SetActive(false);
          AudioSource.PlayClipAtPoint(sfx, this.gameObject.transform.position);
          activado = true;
        }  

        if(other.CompareTag("pizza2"))
        {
          sex2.gameObject.SetActive(false);
          other.gameObject.SetActive(false);
          AudioSource.PlayClipAtPoint(sfx, this.gameObject.transform.position);
          activado2 = true;
        }  

        if(other.CompareTag("Action"))
        {
          if(activado ==true && activado2 == true)
          {
            //CharacterController cc = jugador.GetComponent<CharacterController>();
            //cc.enabled = false;
            jugador.transform.position = target.transform.position;
            //cc.enabled = true;
          }
          else
          {
            activado = false;
            activado2 = false;
            jugador.transform.position = target.transform.position;
             sex2.gameObject.SetActive(true);
             sex.gameObject.SetActive(true);
             pisa1.gameObject.SetActive(true);
             pisa2.gameObject.SetActive(true);


          }
        }  

    }
    
  

   
}
