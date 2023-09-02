using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

[System.Serializable]
public class Boundary
{
  public float xMin, xMax, zMin, zMax;

}
public class PlayerController : MonoBehaviour
{ 
  Rigidbody physics;
  [SerializeField] int speed;
  public Boundary boundary;

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
      Mathf.Clamp(physics.position.x, boundary.xMin, boundary.xMax),
      0,
      Mathf.Clamp(physics.position.z, boundary.zMin, boundary.zMax)
      );
    physics.position = position;
  }
}
