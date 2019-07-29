
using UnityEngine;

namespace ProjectileMotion
{
  public class ProjectileMotion
  {
    // Horizontal distance travelled by the object along the projectile.
    public static float HorizontalDistance(float initialVelocity, float angle, float time)
    {
      return initialVelocity * Mathf.Cos(angle) * time;
    }

    // Time of ascent
    public static float AscentTime(float initialVelocity, float angle, float acceleration)
    {
      return initialVelocity * Mathf.Sin(angle) / acceleration;
    }

    // Time of Descent
    public static float DescentTime(float initialVelocity, float angle, float acceleration)
    {
      return ProjectileMotion.AscentTime(initialVelocity, angle, acceleration);
    }

    // Time of flight
    public static float FlightTime(float initialVelocity, float angle, float acceleration)
    {
      return 2f * ProjectileMotion.AscentTime(initialVelocity, angle, acceleration);
    }

    // Vertical distance travelled by the object along the projectile
    public static float VerticalDistance(float initialVelocity, float angle, float acceleration)
    {
      return initialVelocity * initialVelocity * Mathf.Sin(angle) * Mathf.Sin(angle) / (2f * acceleration);
    }

    // Velocity required to hit the object from point a to point b
    public static Vector3 Velocity(Vector3 pointA, Vector3 pointB, float height, float acceleration)
    {
      float displacementY = pointB.y - pointA.y;
      Vector3 displacementXZ = new Vector3(pointB.x - pointA.x, 0f, pointB.z - pointA.z);

      Vector3 upVelocity = Vector3.up * Mathf.Sqrt(-2f * acceleration * height);

      float tup = Mathf.Sqrt(-2f * height / acceleration);
      float tdown = Mathf.Sqrt(2f * (displacementY - height) / acceleration);
      Vector3 downVelocity = displacementXZ / (tup + tdown);

      return upVelocity + downVelocity;
    }
  }
}
