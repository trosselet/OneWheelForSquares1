using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalEndTime : MonoBehaviour
{
    private void Update()
    {
        StartCoroutine(FinalTime());
    }
    public IEnumerator FinalTime()
    {
        yield return new WaitForSeconds(35);
        SceneManager.LoadScene("Menu");

    }
}
