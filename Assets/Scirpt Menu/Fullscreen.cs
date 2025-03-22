using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Full_Screen : MonoBehaviour
{
    public Button Return;
    // Start is called before the first frame update
    void Start()
    {
        Return.onClick.AddListener(Fullscreen);
    }
    void Fullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }
}