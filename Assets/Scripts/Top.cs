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

    public StringConstant GroundTag;
    public SpinVariableInstancer CurrentSpin;

    public TopValueList TopsInScene;

    public float SpinDelta;

    float knockbackTimer;
    bool collisionLock;

    Vector3 directionalInput;
    bool spinInput;

    void Awake ()
    {
        knockbackTimer = 0;
        CurrentSpin.Value = Stats.InitialSpin;
        TopsInScene.Add(this);
    }

    void Update ()
    {
        updateSpin();

        knockbackTimer -= Time.deltaTime;

        if (CurrentSpin.Value == Spin.MIN)
        {
            TopsInScene.Remove(this);
            Destroy(gameObject);
        }
    }

    void FixedUpdate ()
    {
        if (knockbackTimer <= 0)
        {
            float accel = Stats.EffectiveAcceleration(CurrentSpin.Value);
            Rigidbody.AddForce(directionalInput * accel, ForceMode.Acceleration);
        }

        Rigidbody.velocity = Vector3.ClampMagnitude(Rigidbody.velocity, Stats.MaxSpeed);
    }

    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.HasTag(GroundTag)) return;

        knockbackTimer = Stats.EffectiveKnockbackTime(CurrentSpin.Value);

        Top otherTop = collision.gameObject.GetComponent<Top>();

        if (otherTop == null)
        {
            CurrentSpin.Value /= 2;
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

    public void SetDirectionalInput (Vector3 worldDirection)
    {
        directionalInput = worldDirection.normalized;
    }

    public void SetSpinInput (bool spin)
    {
        spinInput = spin;
    }

    void updateSpin ()
    {
        if (spinInput && -SpinDelta > Stats.SpinClutchPoint)
        {
            SpinDelta = Mathf.Sign(SpinDelta) * Stats.SpinClutchPoint;
        }

        SpinDelta += (spinInput ? Stats.SpinAcceleration : -Stats.SpinDeceleration) * Time.deltaTime;
        SpinDelta = Mathf.Clamp(SpinDelta, -Stats.MaxSpinDelta, Stats.MaxSpinDelta);

        CurrentSpin.Value += SpinDelta * Time.deltaTime;

        if (CurrentSpin.Value == Spin.MAX && SpinDelta > 0)
        {
            SpinDelta = 0;
        }
    }

    void redistributeSpinWith (Top otherTop)
    {
        collisionLock = true;
        otherTop.collisionLock = true;

        bool thisSpunFaster = CurrentSpin.Value == otherTop.CurrentSpin.Value
            ? RandomExtra.Chance(.5f) // ties are broken randomly
            : CurrentSpin.Value > otherTop.CurrentSpin.Value;

        Top fasterSpinningTop = thisSpunFaster ? this : otherTop;
        Top slowerSpinningTop = thisSpunFaster ? otherTop : this;
 
        Spin differential = Mathf.Min(fasterSpinningTop.CurrentSpin.Value, Spin.MAX - slowerSpinningTop.CurrentSpin.Value);

        fasterSpinningTop.CurrentSpin.Value -= differential;
        slowerSpinningTop.CurrentSpin.Value += differential;
    }
}
