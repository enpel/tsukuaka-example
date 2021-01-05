using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MultipleJump : MonoBehaviour, IJumpModule
{
    [SerializeField] int maxJumpCount = 2;
    [SerializeField] int firstJumpPower = 300;
    [SerializeField] int multipleJumpPower = 250;

    int _currentJumpCount = 0;
    bool _isJumping = false;
    Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = this.GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        // もうジャンプできないならジャンプしない
        if (_currentJumpCount >= maxJumpCount)
        {
            return;
        }

        var jumpPower = _currentJumpCount == 0 ? firstJumpPower : multipleJumpPower;
        _rigidbody.AddForce(Vector3.up * jumpPower);

        _rigidbody.velocity = Vector3.zero;
        _isJumping = true;
        _currentJumpCount++;
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
                    _currentJumpCount = 0;
                }
            }
        }
    }
}
