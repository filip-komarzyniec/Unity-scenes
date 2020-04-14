using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeAfterTime : MonoBehaviour
{
    public GameObject explosionPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Explode", 5);
    }

    void Explode() {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);  // z małej litery w C# są zmienne 
    }
}
