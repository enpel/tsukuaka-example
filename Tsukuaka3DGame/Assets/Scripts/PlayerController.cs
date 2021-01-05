using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float runSpeed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal"); // 横方向の入力が-1～+1
        var z = Input.GetAxis("Vertical");　// 縦方向の入力が-1～+1

        this.transform.Translate(new Vector3(x, 0, z) * Time.deltaTime * runSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
        }
    }
}
