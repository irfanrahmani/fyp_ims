
using UnityEngine;

public class InGame_AerialSpawner_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Parent_GO;
    public Transform SpawnPoint_GO;
    public SpawnerInfo_ScripObj ScripObj_Spawn_Script;
   // [SerializeField] private Quaternion RoationTO_Plane_QA;
    void Start()
    {
        Spawning_Fun();
    }

    private void Spawning_Fun()
    {
        GameObject Spawned_GO = Instantiate(ScripObj_Spawn_Script.Arr_ObjectsSpawn[ScripObj_Spawn_Script.Int_Navigation_Index], SpawnPoint_GO.position, ScripObj_Spawn_Script.Arr_ObjectsSpawn[ScripObj_Spawn_Script.Int_Navigation_Index].transform.rotation);
        Spawned_GO.transform.SetParent(Parent_GO.transform);
        Spawned_GO.name = ScripObj_Spawn_Script.Arr_ObjectsSpawn[ScripObj_Spawn_Script.Int_Navigation_Index].gameObject.name;
    }

    
}
