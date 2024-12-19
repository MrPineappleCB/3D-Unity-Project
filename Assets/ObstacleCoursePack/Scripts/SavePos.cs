using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePos : MonoBehaviour
{
	public Transform checkPoint;
	public GameObject uiobject;

    private void Start()
    {
        uiobject.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			col.gameObject.GetComponent<CharacterControls>().checkPoint = checkPoint.position;
			uiobject.SetActive(true);
		}
	}

    private void OnTriggerExit(Collider other)
    {
        uiobject.SetActive(false);
    }
}
