using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DalleActive : MonoBehaviour
{
    public bool DestroyElement;
    public bool IsDestroy = false;
    public GameObject Element;
    public int NbInput;
    public bool Activate;


    private void Update()
    {
        if (IsDestroy == false)
        {
            Activate = true;
            for (int i = 1; i <= NbInput; i++)
            {
                if (GameObject.Find("Dalle" + i.ToString()).GetComponent<Dalle>().EtatInput == false)
                {
                    Activate = false;
                }
            }

            if (Activate == true)
            {
                if (DestroyElement)
                {
                    Destroy(Element);
                    IsDestroy = true;
                }
                else
                {
                    Element.SetActive(false);
                }
            }
            else
            {
                Element.SetActive(true);
            }

        }
    }
}
