using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestConnect : MonoBehaviourPunCallbacks
{
    private void Start()
    {
        print("...");
        PhotonNetwork.NickName = MasterManager.GameSettigns.NickName;
        PhotonNetwork.GameVersion = MasterManager.GameSettigns.GameVersion;
        PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.GameVersion = "0.0.1";
    }

    public override void OnConnectedToMaster()
    {
        print("Connected");
        print(PhotonNetwork.LocalPlayer.NickName);

        PhotonNetwork.JoinLobby();
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        //base.OnDisconnected(cause);
        print("Disconnected from" + cause.ToString());
    }
}
