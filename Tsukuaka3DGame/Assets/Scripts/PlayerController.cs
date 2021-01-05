using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float runSpeed = 3.0f;

    bool _isJumping = false;
    Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = this.GetComponent<Rigidbody>();


    }

    private void Update()
    {
        var x = Input.GetAxis("Horizontal"); // 横方向の入力が-1～+1
        var z = Input.GetAxis("Vertical");　// 縦方向の入力が-1～+1

        this.transform.Translate(new Vector3(x, 0, z) * Time.deltaTime * runSpeed);

        if (Input.GetKeyDown(KeyCode.Space) && !_isJumping)
        {
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.AddForce(Vector3.up * 300);
            _isJumping = true;
        }

        if (_isJumping && _rigidbody.velocity.y < 0)
        {
            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
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
