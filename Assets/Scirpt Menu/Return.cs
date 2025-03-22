using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Option : MonoBehaviour
{
    public Button Return; 
    // Start is called before the first frame update
    void Start()
    {
        Return.onClick.AddListener(Return_Menu);
    }
    void Return_Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    // Update is called once per frame

}
