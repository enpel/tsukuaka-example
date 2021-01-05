using UnityEngine;

public class PowerfulJump : MonoBehaviour, IJumpModule
{
    [SerializeField] int jumpPower = 500;

    bool _isJumping = false;
    Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = this.GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        // ジャンプ中はなにもしない
        if (_isJumping)
        {
            return;
        }

        _rigidbody.AddForce(Vector3.up * jumpPower);

        _rigidbody.velocity = Vector3.zero;
        _isJumping = true;
    }
    void Update()
    {
        // ジャンプ中じゃないなら何もしない
        if (!_isJumping)
        {
            return;
        }

        if (_isJumping && _rigidbody.velocity.y < 0)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.down, out hit))
            {
                if (hit.distance < 1.05f)
                {
                    _isJumping = false;
                }
            }
        }
    }
}
