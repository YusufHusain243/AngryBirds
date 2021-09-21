using UnityEngine;

public class YellowBird : Bird
{
    [SerializeField]
    public float _boostForce = 100;
    public bool _hasBoost = false;

    public void Boost()
    {
        if (State == BirdState.Thrown && !_hasBoost)
        {
            RigidBody.AddForce(RigidBody.velocity * _boostForce);
            _hasBoost = true;
        }
    }

    public void OnTap()
    {
        Boost();
    }
}