using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

// MonoBehaviourPunCallbacksを継承して、PUNのコールバックを受け取れるようにする
public class saba : MonoBehaviourPunCallbacks
{
    private void Start() {



        PhotonNetwork.NickName = "Player" + Random.Range(10, 99);


        // PhotonServerSettingsの設定内容を使ってマスターサーバーへ接続する
        PhotonNetwork.ConnectUsingSettings();




    }

    // マスターサーバーへの接続が成功した時に呼ばれるコールバック
    public override void OnConnectedToMaster() {
        // "Room"という名前のルームに参加する（ルームが存在しなければ作成して参加する）
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions(), TypedLobby.Default);
    }

    // ゲームサーバーへの接続が成功した時に呼ばれるコールバック
    public override void OnJoinedRoom() {
        // ランダムな座標に自身のアバター（ネットワークオブジェクト）を生成する
        var position = new Vector3(-100,0);
        GameObject player = PhotonNetwork.Instantiate("Avatar", position, Quaternion.identity);
        player.name = PhotonNetwork.LocalPlayer.NickName;

    }
}