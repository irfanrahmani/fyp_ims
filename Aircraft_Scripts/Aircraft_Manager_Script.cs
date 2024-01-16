using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraft_Manager_Script : MonoBehaviour
{
    public GameObject Trail_Left_GO;
    public GameObject Trail_Right_GO;
    public Vector3[] Give_left_Trail_POS;
    public Vector3[] Give_right_Trail_POS;
    public GameObject Parent_JetController_GO;
    public SpawnerInfo_ScripObj Spawner_ScriptOBJ;



    private void Start()
    {
       
            Trail_Left_GO.transform.position = Parent_JetController_GO.transform.position + Give_left_Trail_POS[Spawner_ScriptOBJ.Int_Navigation_Index];
            Trail_Right_GO.transform.position = Parent_JetController_GO.transform.position + Give_right_Trail_POS[Spawner_ScriptOBJ.Int_Navigation_Index];

       
        
    }
}
