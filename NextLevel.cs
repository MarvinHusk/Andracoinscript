using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public GameObject Player;
   private void OnTriggerEnter(Collider other)
   {
       if(other.gameObject == Player)
       {           
           
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       }
   }
}
