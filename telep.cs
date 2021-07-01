using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telep : MonoBehaviour
{
     public GameObject plyr, target;
     void OnTriggerEnter(Collider other)
  {
    if(other.gameObject == plyr){
      plyr.transform.position = target.transform.position;
    }
  }
}
