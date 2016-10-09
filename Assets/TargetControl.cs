using UnityEngine;
using System.Collections;

public class TargetControl : MonoBehaviour {
    bool isQuitting = false;
    GameObject target_inst;

    public GameObject target;
    public float height = 3.0f;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(0.0f, height, 0.0f);
        target_inst = Instantiate<GameObject>(target);
        target_inst.transform.parent = transform;
	}

    void OnTriggerEnter(Collider other)
    {
        Destroy(target_inst);
        target_inst = Instantiate<GameObject>(target);

        transform.position = new Vector3(Random.Range(-5.0f, 5.0f), height, Random.Range(-5.0f, 5.0f));

        target_inst.transform.parent = transform;
        target_inst.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
    }
}
