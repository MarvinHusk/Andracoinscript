using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPizza : MonoBehaviour
{
    public GameObject Player, sex;

    bool activado = false;
    public AudioClip sfx;
    public void OnTriggerEnter(Collider other)
    {

        if(other.gameObject == Player && activado == false)
        {
          sex.gameObject.SetActive(false);
          AudioSource.PlayClipAtPoint(sfx, this.gameObject.transform.position);
          activado = true;
          gameObject.SetActive(false);
        }  
    }
}
