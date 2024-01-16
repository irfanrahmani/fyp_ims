using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_s_Script : MonoBehaviour
{

    private void Start()
    {
        Invoke("SelfDestruct_fun", 10.0f);
    }
    private void SelfDestruct_fun()
    {
        Destroy(this);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 100);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(this);
    }
}
