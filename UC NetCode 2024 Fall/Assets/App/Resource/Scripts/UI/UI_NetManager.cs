using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.UI;

public class UI_NetManager : NetworkBehaviour
{

    [SerializeField] private Button _serverBttn, _clientBttn, _hostBttn;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        _hostBttn.onClick.AddListener(Hostclick);
        _clientBttn.onClick.AddListener(ClientClick);
            _serverBttn.onClick.AddListener(ServerClick);
    }

    
  

    private void ServerClick()
    {
        NetworkManager.Singleton.StartServer();      // Starts the NetworkManager as just a server (that is, no local client).
        this.gameObject.SetActive(false);
    }
    
    private void ClientClick()
    {
       NetworkManager.Singleton.StartClient();      // Starts the NetworkManager as just a client.
       this.gameObject.SetActive(false);
    }

    private void Hostclick()
    {
        NetworkManager.Singleton.StartHost();        // Starts the NetworkManager as both a server and a client (that is, has local client)
        this.gameObject.SetActive(false);
    }
}
