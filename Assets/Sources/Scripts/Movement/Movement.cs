using UnityEngine;

public class Movement
{
    private readonly Rigidbody _rigidbody;
    private readonly float _speed;
    private readonly float _jumpForce;

    public Movement(Rigidbody rigidbody, float speed, float jumpForce)
    {
        _rigidbody = rigidbody;
        _speed = speed;
        _jumpForce = jumpForce;
    }

    public void Move()
    {
        _rigidbody.velocity = new Vector3(0, _rigidbody.velocity.y, _speed);
    }

    public void Jump()
    {
        _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode.Impulse);
    }
}
