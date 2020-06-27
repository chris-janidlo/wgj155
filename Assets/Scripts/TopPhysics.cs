using UnityEngine;

public class TopPhysics : MonoBehaviour
{
    public TopStats Stats;
    public Rigidbody Rigidbody;

    float knockbackTimer;
    Vector3 input;

    void Start ()
    {
        knockbackTimer = Stats.KnockbackTime;
    }

    void Update ()
    {
        knockbackTimer += Time.deltaTime;
    }

    void FixedUpdate ()
    {
        if (knockbackTimer >= Stats.KnockbackTime)
            Rigidbody.AddForce(input * Stats.Acceleration, ForceMode.Acceleration);

        Rigidbody.velocity = Vector3.ClampMagnitude(Rigidbody.velocity, Stats.MaxSpeed);
    }

    void OnCollisionEnter (Collision collision)
    {
        knockbackTimer = 0;
    }

    public void SetInput (Vector3 worldDirection)
    {
        input = worldDirection.normalized;
    }
}
