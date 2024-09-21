using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovementRoot : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _speed;

    private Rigidbody _rigidbody;
    private Movement _movement;
    private bool _isGrounded;

    public void Init()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _movement = new Movement(_rigidbody, _speed, _jumpForce);
    }

    private void FixedUpdate()
    {
        _movement.Move();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _isGrounded = true;
    }

    public void OnJump()
    {
        if (_isGrounded == false)
            return;

        _movement.Jump();
        _isGrounded = false;
    }
}
