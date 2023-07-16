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
            // �{�^���̃N���b�N�C�x���g�Ƀ��\�b�h��ǉ�
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
            // PhotonNetwork���ڑ�����Ă��Ȃ����A���[���ɓ����Ă��Ȃ��ꍇ�͏������s��Ȃ�
            return;
        }

        if (playersWhoPressedButton.Contains(PhotonNetwork.LocalPlayer.ActorNumber))
        {
            // ���Ƀ{�^�����������v���C���[�͏������s��Ȃ�
            return;
        }

        // �{�^�����������v���C���[��ID���擾
        int playerID = PhotonNetwork.LocalPlayer.ActorNumber;

        // �v���C���[��ID���g���ĉ��炩�̏������s��
        Debug.Log("Player " + playerID + " pressed a button.");

        // �{�^�����������v���C���[���L�^���A�{�^���𖳌�������
        playersWhoPressedButton.Add(playerID);
        button.interactable = false;
        isClick = button.interactable;
        

        // �v���C���[���S�Ẵ{�^���������I��������`�F�b�N
        if (playersWhoPressedButton.Count == buttons.Count)
        {
            // �S�Ẵv���C���[���{�^�����������ꍇ�̏���
            Debug.Log("All players have pressed buttons.");
        }

        // ���̑��̏���...
    }
}