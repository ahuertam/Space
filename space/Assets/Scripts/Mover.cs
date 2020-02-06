using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Mover : MonoBehaviour
{
  public float movementSpeed = 5.0f;
  private Vector3 moveDirection = Vector3.zero;
  private Rigidbody _rigidBody;
  void Start()
  {
    _rigidBody = GetComponent<Rigidbody>();
  }
  void FixedUpdate()
  {
    Move();
  }

  private void Move()
  {
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");
    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
    _rigidBody.AddForce(movement * movementSpeed);
  }
}