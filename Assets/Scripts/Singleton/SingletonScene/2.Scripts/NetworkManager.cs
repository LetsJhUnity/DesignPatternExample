using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class NetworkManager : TSingleton<NetworkManager>
{
    public void OnConnectNetworkServer()
    {

    }
}

public class LoginSystem : MonoBehaviour
{

    private void Awake()
    {
        NetworkManager.Instance.OnConnectNetworkServer();
    }
}
