using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easter_egg : MonoBehaviour
{
    public GameObject uiobject;

    private void Start()
    {
        uiobject.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            uiobject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        uiobject.SetActive(false);
    }

}
