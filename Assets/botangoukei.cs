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
            // ボタンのクリックイベントにメソッドを追加
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
            // PhotonNetworkが接続されていないか、ルームに入っていない場合は処理を行わない
            return;
        }

        // ボタンの名前を取得
        string buttonName = button.name;

        if (!buttonPressCounts.ContainsKey(buttonName))
        {
            // ボタンが初めて押された場合、回数を1で初期化
            buttonPressCounts.Add(buttonName, 1);
        }
        else
        {
            // ボタンが既に押されている場合、回数をインクリメント
            buttonPressCounts[buttonName]++;
        }

        // その他の処理...
    }

    private void CalculateMostPressedButton()
    {
        // 合計回数が最大となるボタンを取得
        var mostPressedButton = buttonPressCounts.OrderByDescending(kv => kv.Value).FirstOrDefault();

        if (mostPressedButton.Key != null)
        {
            
                botan = GameObject.Find(mostPressedButton.Key);
                text = botan.transform.Find("Text (Legacy)").gameObject;
                syokei = text.GetComponent<Text>().text;
                text.GetComponent<Text>().text = " ";
                syokeii = GameObject.Find(syokei);
                Destroy(syokeii);

            // 最も押された回数が多いボタンを表示



            Debug.Log("Most pressed button: " + mostPressedButton.Key + " (" + mostPressedButton.Value + " presses)");
        }
        else
        {
            // ボタンが押されていない場合の処理
            Debug.Log("No button has been pressed yet.");
        }
    }
    

    public override void OnLeftRoom()
    {
        // ルームから退出した際に最も押されたボタンを計算する
        CalculateMostPressedButton();
    }
}