using System;
using UnityEngine;
using UnityAtoms;
using UnityAtoms.Tags;
using UnityAtoms.BaseAtoms;
using crass;

public class Top : MonoBehaviour, IEquatable<Top>
{
    public TopStats Stats;
    public Rigidbody Rigidbody;

    public TopEvent TopDied;
    public StringConstant GroundTag;
    public SpinVariableInstancer SpinVariableInstancer;

    public Spin CurrentSpin
    {
        get => SpinVariableInstancer.Value;
        private set => SpinVariableInstancer.Value = value;
    }

    float knockbackTimer;
    Vector3 input;
    bool collisionLock;

    void Start ()
    {
        knockbackTimer = Stats.KnockbackTime;
        CurrentSpin = Stats.InitialSpin;
    }

    void Update ()
    {
        knockbackTimer += Time.deltaTime;

        if (CurrentSpin == Spin.MIN)
        {
            TopDied.Raise(this);
            Destroy(gameObject);
        }
    }

    void FixedUpdate ()
    {
        if (knockbackTimer >= Stats.KnockbackTime)
            Rigidbody.AddForce(input * Stats.Acceleration, ForceMode.Acceleration);

        Rigidbody.velocity = Vector3.ClampMagnitude(Rigidbody.velocity, Stats.MaxSpeed);
    }

    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.HasTag(GroundTag)) return;

        knockbackTimer = 0;

        Top otherTop = collision.gameObject.GetComponent<Top>();

        if (otherTop == null)
        {
            CurrentSpin /= 2;
        }
        else if (!collisionLock && !otherTop.collisionLock)
        {
            redistributeSpinWith(otherTop);
        }
    }

    void OnCollisionExit (Collision collision)
    {
        if (collision.gameObject.HasTag(GroundTag)) return;

        collisionLock = false;
    }

	public bool Equals (Top other)
	{
        return this == other;
	}

    public void SetInput (Vector3 worldDirection)
    {
        input = worldDirection.normalized;
    }

    void redistributeSpinWith (Top otherTop)
    {
        collisionLock = true;
        otherTop.collisionLock = true;

        bool thisSpunFaster = CurrentSpin == otherTop.CurrentSpin
            ? RandomExtra.Chance(.5f) // ties are broken randomly
            : CurrentSpin > otherTop.CurrentSpin;

        Top fasterSpinningTop = thisSpunFaster ? this : otherTop;
        Top slowerSpinningTop = thisSpunFaster ? otherTop : this;
 
        Spin differential = Mathf.Min(fasterSpinningTop.CurrentSpin, Spin.MAX - slowerSpinningTop.CurrentSpin);

        fasterSpinningTop.CurrentSpin -= differential;
        slowerSpinningTop.CurrentSpin += differential;
    }
}
