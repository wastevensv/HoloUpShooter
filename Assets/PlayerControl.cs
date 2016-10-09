using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
    public float tiltSpeed = 20.0f;
    public float XRange = 30.0f;
    public float ZRange = 30.0f;

    Vector3 rotation;
    // Use this for initialization
    void Start()
    {
        rotation = transform.rotation.eulerAngles;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * tiltSpeed;
        float moveVertical = Input.GetAxis("Vertical") * tiltSpeed;

        rotation += new Vector3(moveHorizontal, 0.0f, moveVertical);
        rotation.x = Mathf.Clamp(rotation.x, -XRange, XRange);
        rotation.z = Mathf.Clamp(rotation.z, -ZRange, ZRange);
        transform.rotation = Quaternion.Euler(rotation);
    }
}
