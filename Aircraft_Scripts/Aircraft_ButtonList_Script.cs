using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aircraft_ButtonList_Script : MonoBehaviour
{
    public Aircraft_Bullet_Spawner[] BulletSpawner_Script;
    public GameObject[] BulletSpawnTag_GO;

    public void Func1()
    {
        for (int i = 0; i < BulletSpawner_Script.Length; i++)
        {
            BulletSpawner_Script[i].BulletSpawning_Fun();
        }

    }

    void Start()
    {
        
        Button myButton = GetComponent<Button>();

        
        myButton.onClick.AddListener(Func1);
        Invoke("FindBullet_GO", 0.5f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Func1();

    }
    void FindBullet_GO()
    {
        BulletSpawnTag_GO = GameObject.FindGameObjectsWithTag("BulletSpawnerTag");

       
            BulletSpawner_Script[0] = BulletSpawnTag_GO[0].GetComponent<Aircraft_Bullet_Spawner>();
        BulletSpawner_Script[1] = BulletSpawnTag_GO[1].GetComponent<Aircraft_Bullet_Spawner>();

    }
}
