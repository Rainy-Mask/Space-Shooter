using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyByBoundry : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
   {
      Destroy(other.gameObject);
   }
}
