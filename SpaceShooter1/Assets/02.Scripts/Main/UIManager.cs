using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void OnClickStartBtn()
    {
        SceneManager.LoadScene("SceneLoader");
        //SceneManager.LoadScene("Level1");
        //SceneManager.LoadScene("Play", LoadSceneMode.Additive);
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
