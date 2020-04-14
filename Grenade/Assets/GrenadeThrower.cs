using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrower : MonoBehaviour
{
    public Rigidbody grenadePrefab;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)) {
           var grenade =  Instantiate(grenadePrefab, transform.position, Quaternion.identity);
           grenade.AddForce(transform.forward*300);
        }
    }
}
