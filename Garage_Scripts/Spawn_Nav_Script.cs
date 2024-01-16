using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Nav_Script : MonoBehaviour
{
    public SpawnerInfo_ScripObj Spawner_ScripObj;
    [SerializeField] private OnlyforAerial_Info_Script[] Arr_AvailberAerial_Script;
 

    private void OnEnable()
    {
        AerialSpawner_Fun(Spawner_ScripObj.Int_Navigation_Index);
    }

    //This is the Main Spawn Function for Spawning Aerial;
    public void AerialSpawner_Fun(int index)
    {
        DestroyAvailAerial_Fun();

        Spawner_ScripObj.Int_Navigation_Index = index; 
        // This line is just instantiating and code is long bcz of long variable name.
        GameObject SpawnedObj = Instantiate(Spawner_ScripObj.Arr_ObjectsSpawn[Spawner_ScripObj.Int_Navigation_Index], Spawner_ScripObj.GO_Spawning_Object.transform.position, Spawner_ScripObj.GO_Spawning_Object.transform.rotation);
        SpawnedObj.name = Spawner_ScripObj.Arr_ObjectsSpawn[Spawner_ScripObj.Int_Navigation_Index].gameObject.name;
    }

    // this function is for getting last saved Aerial
    public void AssistInAerialSpawner_Fun()
    {
        AerialSpawner_Fun(Spawner_ScripObj.Int_Navigation_Index);
    }


    //Add this function onClick to CloseButton from Garage
    public void DestroyAvailAerial_Fun()
    {
        Arr_AvailberAerial_Script = null;
        Arr_AvailberAerial_Script = FindObjectsOfType<OnlyforAerial_Info_Script>();


        if(Arr_AvailberAerial_Script == null)
        {
            print("Poonka");
        }
        else
        {
            foreach (var obj in Arr_AvailberAerial_Script)
            {
                Destroy(obj.gameObject);
            }
        }
        
    }

    
}
