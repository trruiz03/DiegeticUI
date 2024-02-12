using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{

    public GameObject spatialButton, mapButton, compassButton, escapeMenu;
    public GameObject menuPanel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            menuPanel.SetActive(!menuPanel.activeInHierarchy);
            
        }
    }

    public void blood(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void map(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void compass(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Escape(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
