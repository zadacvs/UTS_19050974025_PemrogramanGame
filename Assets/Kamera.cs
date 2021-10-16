using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    public GameObject Bola;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Bola.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Bola.transform.position + offset;
    }
}
