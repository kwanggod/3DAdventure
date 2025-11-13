using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButton : MonoBehaviour
{
    private void OnTriggerEnter(Collider Collision)
    {
        Rigidbody _rigidbody = Collision.GetComponent<Rigidbody>();
        _rigidbody.AddForce(Vector2.up * 160f, ForceMode.Impulse);
    }
}
