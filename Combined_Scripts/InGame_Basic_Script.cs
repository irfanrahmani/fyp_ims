using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGame_Basic_Script : MonoBehaviour
{
    // This function is for going to desired scene.
    public void Go_Desired_Scene_Index_Fun(int index)
    {
        SceneManager.LoadSceneAsync(index);
    }

}
