using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerL : MonoBehaviour
{
    public GameObject boomerang;
    public Rigidbody boomerangRb;

    public float trowForce;


    // Start is called before the first frame update
    void Start()
    {
        boomerangRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BoomerangThrow();
        }
    }

    public void BoomerangThrow()
    {
        boomerangRb.isKinematic = false;
        boomerangRb.transform.parent = null;
        boomerangRb.AddForce(transform.forward * trowForce, ForceMode.Impulse);
    }
}
