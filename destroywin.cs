using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroywin : MonoBehaviour
{
   public Collider katana;

   private void OnTriggerEnter(Collider other) {
       if(other == katana)
       {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       }
   }
}
