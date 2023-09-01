using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
  Rigidbody physics;
  public int speed;

  void Start()
  {
    physics = GetComponent<Rigidbody>();
  }

  void FixedUpdate()
  {
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

    physics.velocity = movement * speed;
  }
}
