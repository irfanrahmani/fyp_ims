using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas_Buttons_Script : MonoBehaviour
{
    //Only is loading scene with index.
    public void PlayScene_Index_Fun(int index)
    {
        SceneManager.LoadSceneAsync(index);
    }

    // Application Quit function
    public void QuitAPP_fun()
    {
        Application.Quit();
    }
    
}
