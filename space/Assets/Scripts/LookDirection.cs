using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LookDirection : MonoBehaviour
{
  private Vector3 lastPos;
  private Vector3 velocity;
  private void Start()
  {
    lastPos = transform.position;
    velocity = transform.position - lastPos;
  }
  private void FixedUpdate()
  {
    velocity = transform.position - lastPos;
    lastPos = transform.position;
    lookTowardDirectionOfVelocity();
  }
  void lookTowardDirectionOfVelocity()
  {
    transform.rotation = Quaternion.LookRotation(velocity);
  }
}