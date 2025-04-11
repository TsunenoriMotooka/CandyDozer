using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject[] candyPrefabs;
    public Transform candyParentTransform;
    public float shotForce;
    public float shotTorque;
    public float baseWidth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject candy = Instantiate(SampleCandy(), GetInstantiatePosition(), Quaternion.identity);
        candy.transform.parent = candyParentTransform;

        Rigidbody rb = candy.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * shotForce);
        rb.AddTorque(new Vector3(0, shotTorque, 0));
    }

    GameObject SampleCandy()
    {
        int index = Random.Range(0, candyPrefabs.Length);
        return candyPrefabs[index];
    }

    Vector3 GetInstantiatePosition()
    {
        float x = (baseWidth * (Input.mousePosition.x / Screen.width)) - (baseWidth / 2);
        return transform.position + new Vector3(x, 0, 0);
    }
}
