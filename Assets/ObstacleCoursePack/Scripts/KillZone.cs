using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    private FallPlat[] fallPlatforms;

    private void Start()
    {
        fallPlatforms = FindObjectsOfType<FallPlat>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
			col.gameObject.GetComponent<CharacterControls>().LoadCheckPoint();
		}

        foreach(var platform in fallPlatforms)
        {
            platform.ResetPlatform();
        }
	}
}
