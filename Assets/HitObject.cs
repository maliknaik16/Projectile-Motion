
using UnityEngine;
using ProjectileMotion;

public class HitObject : MonoBehaviour
{
  public Transform pointA;
  public Transform pointB;

  [SerializeField]
  float height = 10f;

  Vector3 velocity;
  float gravity;
  bool launch = false;
  Rigidbody rb;

  void Start() {
    gravity = Physics.gravity.y;
    velocity = ProjectileMotion.ProjectileMotion.Velocity(pointA.position, pointB.position, height, gravity);
    rb = GetComponent<Rigidbody>();
  }

  void Update() {
    if(Input.GetKeyDown(KeyCode.Space)) {
      launch = true;
    }
  }

  void FixedUpdate() {
    if(launch == true) {
      launch = false;
      rb.velocity = velocity;
    }
  }
}
