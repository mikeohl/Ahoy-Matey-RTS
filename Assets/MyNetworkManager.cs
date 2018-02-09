using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MyStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " : Starting Host at ");
        StartHost();
    }

    public override void OnStartHost ()
    {
        Debug.Log(Time.timeSinceLevelLoad + " : Host Started at ");
    }

    public override void OnStartClient(NetworkClient client)
    {
        Debug.Log(Time.timeSinceLevelLoad + " : Client Start Requested");
        InvokeRepeating("PrintDots", 0f, 1f);
        //base.OnStartClient(client);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        CancelInvoke();
        Debug.Log(Time.timeSinceLevelLoad + " : Client is connected to IP: " + conn.address);
        //base.OnClientConnect(conn);
    }

    void PrintDots ()
    {
        Debug.Log(".");
    }
}
