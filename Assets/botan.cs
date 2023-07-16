using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;

public class botan : MonoBehaviourPunCallbacks
{
    


    public nagare na;
    public List<Button> buttons;
    private HashSet<int> playersWhoPressedButton;
    public bool isClick = true;

    private void Start()
    {
        buttons = new List<Button>(GetComponentsInChildren<Button>());
        playersWhoPressedButton = new HashSet<int>();

        foreach (Button button in buttons)
        {
            // ボタンのクリックイベントにメソッドを追加
            button.onClick.AddListener(() => OnButtonClick(button));
        }
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        base.OnPlayerEnteredRoom(newPlayer);
    }
 
      

    public void OnButtonClick(Button button)
    {
        if (!PhotonNetwork.IsConnected || !PhotonNetwork.InRoom)
        {
            // PhotonNetworkが接続されていないか、ルームに入っていない場合は処理を行わない
            return;
        }

        if (playersWhoPressedButton.Contains(PhotonNetwork.LocalPlayer.ActorNumber))
        {
            // 既にボタンを押したプレイヤーは処理を行わない
            return;
        }

        // ボタンを押したプレイヤーのIDを取得
        int playerID = PhotonNetwork.LocalPlayer.ActorNumber;

        // プレイヤーのIDを使って何らかの処理を行う
        Debug.Log("Player " + playerID + " pressed a button.");

        // ボタンを押したプレイヤーを記録し、ボタンを無効化する
        playersWhoPressedButton.Add(playerID);
        button.interactable = false;
        isClick = button.interactable;
        

        // プレイヤーが全てのボタンを押し終わったかチェック
        if (playersWhoPressedButton.Count == buttons.Count)
        {
            // 全てのプレイヤーがボタンを押した場合の処理
            Debug.Log("All players have pressed buttons.");
        }

        // その他の処理...
    }
}