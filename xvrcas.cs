using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class xvrcas : MonoBehaviour
{
   public Collider katana;

   public AudioClip aaa;
   public GameObject jugador, enemigo;

   private void OnTriggerEnter(Collider other) {
       if(other == katana)
       {
         AudioSource.PlayClipAtPoint(aaa, this.gameObject.transform.position);
         Destroy(this.gameObject);
       }
       if(other.gameObject == jugador)
       {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       }

   }
}
