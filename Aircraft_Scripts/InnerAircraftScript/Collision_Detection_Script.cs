
using UnityEngine;

public class Collision_Detection_Script : MonoBehaviour
{
    public GameObject[] Partsof_Plane_GO;


    private void Start()
    {
        Invoke("Test", 0.5f);
    }
    private void Test()
    {
        Partsof_Plane_GO = GameObject.FindGameObjectsWithTag("HeliParts_Tag");
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CollisionTag"))
        {
            print("Triggered Detected");
            ExplodePlane_Fun();
        }
        
    }

    private void ExplodePlane_Fun()
    {
        foreach (GameObject obj in Partsof_Plane_GO)
        {
            obj.GetComponent<BoxCollider>().enabled = true;
            Rigidbody RB_PlanePart = obj.GetComponent<Rigidbody>();
            RB_PlanePart.isKinematic = false;
            RB_PlanePart.useGravity = true;
        }
    }
}
