using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class botangoukei : MonoBehaviourPunCallbacks
{

    /*public bool uranai;
    public bool reinou;
    public bool kariudo;
    public bool nityou;
    public bool buki;
    public bool bougu;
    public bool isya;
    public bool banken;
    public bool niseuranai;
    public bool zinrou;
    public bool reinourou;
    public bool sasori;
    public bool kariudokira;
    public bool mazyutusi;
    public bool husi;
    public bool zonbi;*/










    public nagare na;
    public GameObject botan;
    public GameObject text;
    public GameObject syokeii;
    private List<Button> buttons;
    private Dictionary<string, int> buttonPressCounts;
    private Dictionary<string, int> buttonPressCountsZ;
    public string syokei;

    private void Start()
    {
        buttons = new List<Button>(GetComponentsInChildren<Button>());
        buttonPressCounts = new Dictionary<string, int>();

        foreach (Button button in buttons)
        {
            // �{�^���̃N���b�N�C�x���g�Ƀ��\�b�h��ǉ�
            button.onClick.AddListener(() => OnButtonClick(button));
        }
    }
    private void Update()
    {
        if (na.yoruu == true)
        {
            CalculateMostPressedButton();
        }
           if (na.hanasiaii == true)
        {
           
        }
          


    }

    public void OnButtonClick(Button button)
    {



        if (!PhotonNetwork.IsConnected || !PhotonNetwork.InRoom)
        {
            // PhotonNetwork���ڑ�����Ă��Ȃ����A���[���ɓ����Ă��Ȃ��ꍇ�͏������s��Ȃ�
            return;
        }

        // �{�^���̖��O���擾
        string buttonName = button.name;

        if (!buttonPressCounts.ContainsKey(buttonName))
        {
            // �{�^�������߂ĉ����ꂽ�ꍇ�A�񐔂�1�ŏ�����
            buttonPressCounts.Add(buttonName, 1);
        }
        else
        {
            // �{�^�������ɉ�����Ă���ꍇ�A�񐔂��C���N�������g
            buttonPressCounts[buttonName]++;
        }

        // ���̑��̏���...
    }

    private void CalculateMostPressedButton()
    {
        // ���v�񐔂��ő�ƂȂ�{�^�����擾
        var mostPressedButton = buttonPressCounts.OrderByDescending(kv => kv.Value).FirstOrDefault();

        if (mostPressedButton.Key != null)
        {
            
                botan = GameObject.Find(mostPressedButton.Key);
                text = botan.transform.Find("Text (Legacy)").gameObject;
                syokei = text.GetComponent<Text>().text;
                text.GetComponent<Text>().text = " ";
                syokeii = GameObject.Find(syokei);
                Destroy(syokeii);

            // �ł������ꂽ�񐔂������{�^����\��



            Debug.Log("Most pressed button: " + mostPressedButton.Key + " (" + mostPressedButton.Value + " presses)");
        }
        else
        {
            // �{�^����������Ă��Ȃ��ꍇ�̏���
            Debug.Log("No button has been pressed yet.");
        }
    }
    

    public override void OnLeftRoom()
    {
        // ���[������ޏo�����ۂɍł������ꂽ�{�^�����v�Z����
        CalculateMostPressedButton();
    }
}