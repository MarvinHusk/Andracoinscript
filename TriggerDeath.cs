using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TriggerDeath : MonoBehaviour
{
   public GameObject Player;
   private void OnTriggerEnter(Collider other)
   {
       if(other.gameObject == Player)
       {           
           Coincls.coinsCount --;
           Coincls.coinsCount = 0;
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       }
   }
}
