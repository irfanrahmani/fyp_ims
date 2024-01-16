using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraft_Bullet_Spawner : MonoBehaviour
{
    public GameObject Bullet_GO;
    public GameObject JetController_GO;

    private void Start()
    {
        JetController_GO = GameObject.FindWithTag("AircraftControllerTag");
    }


    public void BulletSpawning_Fun()
    {
        Instantiate(Bullet_GO, this.transform.position, JetController_GO.transform.rotation);
    }

}
