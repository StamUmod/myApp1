using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class S1Mger : MonoBehaviour
{
    public Button btnStart;
    public Button btnExit;
    void Start()
    {
        btnStart.onClick.AddListener(OnBtnStartClick);
        btnExit.onClick.AddListener(OnBtnExitClick);
    }




    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    
    private void OnBtnStartClick()
    {
        SceneManager.LoadScene("S2");
    }
    
    private void OnBtnExitClick()
    {
        Application.Quit();
    }

    
}

