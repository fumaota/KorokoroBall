using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
   
    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }
    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
