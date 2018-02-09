using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.CrossPlatformInput;

public class Player : NetworkBehaviour {

    private Vector3 input;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isLocalPlayer)
        {
            input.x = CrossPlatformInputManager.GetAxis("Horizontal");
            input.z = CrossPlatformInputManager.GetAxis("Vertical");
            input.y = 0f;

            transform.Translate(input);
        }

	}

    public override void OnStartLocalPlayer()
    {
        Camera view = GetComponentInChildren<Camera>();
        view.enabled = true;
    }
}
