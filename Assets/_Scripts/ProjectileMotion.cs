
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
    public static float AscentTime(float initialVelocity, float angle, float acceleration) {
      return initialVelocity * Mathf.Sin(angle) / acceleration;
    }

    // Time of Descent
    public static float DescentTime(float initialVelocity, float angle, float acceleration) {
      return ProjectileMotion.AscentTime(initialVelocity, angle, acceleration);
    }

    // Time of flight
    public static float FlightTime(float initialVelocity, float angle, float acceleration) {
      return 2f * ProjectileMotion.AscentTime(initialVelocity, angle, acceleration);
    }

    // Vertical distance travelled by the object along the projectile
    public static float VerticalDistance(float initialVelocity, float angle, float acceleration) {
      return initialVelocity * initialVelocity * Mathf.Sin(angle) * Mathf.Sin(angle) / (2f * acceleration);
    }
  }
}
