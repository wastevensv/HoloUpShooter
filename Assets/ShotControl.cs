using UnityEngine;
using System.Collections;

public class ShotControl : MonoBehaviour {

    public Transform aim;
    public float speed = 5.0f;

    Rigidbody rb;
    bool fired = false;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!fired)
        {
            transform.rotation = aim.transform.rotation;
            if (Input.GetButton("Fire1"))
            {
                fired = true;
                rb.velocity = transform.up * speed;
            }
        }
    }

    void Update()
    {
        if(transform.position.y > 5)
        {
            reset();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        reset();
    }

    private void reset()
    {
        rb.velocity = new Vector3(0, 0, 0);
        transform.position = aim.transform.position;
        transform.rotation = aim.transform.rotation;
        fired = false;
    }
}
