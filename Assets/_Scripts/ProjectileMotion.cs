
using UnityEngine;

namespace ProjectileMotion
{
  public class ProjectileMotion
  {
    // Horizontal distance of the object travelled with the projectile.
    public static float HorizontalDistance(float initialVelocity, float angle, float time)
    {
      return initialVelocity * Mathf.Cos(angle) * time;
    }

    public static float AscentTime(float initialVelocity, float angle, float acceleration) {
      return initialVelocity * Mathf.Sin(angle) / acceleration;
    }

    public static float DescentTime(float initialVelocity, float angle, float acceleration) {
      return ProjectileMotion.AscentTime(initialVelocity, angle, acceleration);
    }

    public static float FlightTime(float initialVelocity, float angle, float acceleration) {
      return 2f * ProjectileMotion.AscentTime(initialVelocity, angle, acceleration);
    }
  }
}
