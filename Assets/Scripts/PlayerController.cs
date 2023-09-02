using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
  Rigidbody physics;
  public int speed;
  public float xMin, xMax, zMin, zMax;

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

    Vector3 position = new Vector3(
      Mathf.Clamp(physics.position.x, xMin, xMax),
      0,
      Mathf.Clamp(physics.position.z, zMin, zMax)
      );
    physics.position = position;
  }
}
