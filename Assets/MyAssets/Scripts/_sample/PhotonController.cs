using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using MyAssets;

public class PhotonController : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private GameObject PhotonObject;

    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("connected Master");

        // RoomOptions
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 8;

        // 部屋に入る or 部屋がなかったら作成する
        PhotonNetwork.JoinOrCreateRoom("room", roomOptions, TypedLobby.Default);
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joinded Lobby");
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log("Join Room Failed");
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined Room");
        GameObject myPlayer = PhotonNetwork.Instantiate(
            PhotonObject.name,
            new Vector3(1.89f, 0f, -8.29f),
            Quaternion.identity,
            0
        );

        // MyCharacterクラスの管理
        MyCharacter myCharacter = myPlayer.GetComponent<MyCharacter>();
        myCharacter.enabled = true;

        // MyControllerクラスの管理
        MyController myController = myPlayer.GetComponent<MyController>();
        myController.enabled = true;

        myCharacter.CameraOn();

#if !UNITY_EDITOR
        Calljs.JsCompleteLoad();
#endif
    }
}
