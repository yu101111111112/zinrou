using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class players : MonoBehaviourPunCallbacks
{
    public yakusyokyu ya;
    public botangoukei bo;
    // Start is called before the first frame update
    void Start()
    {


        if (PhotonNetwork.IsMasterClient) {
    Debug.Log("自身がマスタークライアントです");




}
     
 

    }

    // Update is called once per frame
    void Update()
    {
      
    }


   public void nouryoku(int a)
    {
        int playerID = PhotonNetwork.LocalPlayer.ActorNumber;
        
        if (ya.py[playerID] == "uranai")
        {

      
            GameObject uranaibotan = GameObject.Find("Button (Legacy) (" + a + ")");
            GameObject uranaiko = uranaibotan.transform.GetChild(0).gameObject;
            string uranawareru = uranaiko.GetComponent<Text>().text;
            GameObject uranawareruhito = GameObject.Find(uranawareru);
            if (uranawareruhito.gameObject.tag == "banken" || uranawareruhito.gameObject.tag == "ookamiwaki" || uranawareruhito.gameObject.tag == "zinrou" || uranawareruhito.gameObject.tag == "reinourou" || uranawareruhito.gameObject.tag == "syokuyoku" || uranawareruhito.gameObject.tag == "zyurou" || uranawareruhito.gameObject.tag == "husi" || uranawareruhito.gameObject.tag == "nouaru")
            {
                Debug.Log("人狼");
            }
            else
            {
                Debug.Log("人狼ではない");
            }
        }

        if (ya.py[playerID] == "zinrou")
        {


            GameObject zinroubotan = GameObject.Find("Button (Legacy) (" + a + ")");
            GameObject zinrouko = zinroubotan.transform.GetChild(0).gameObject;
            string syuugekisareta = zinrouko.GetComponent<Text>().text;
            GameObject syuugekisaretahito = GameObject.Find(syuugekisareta);
            Destroy(syuugekisaretahito);

        }
        if (ya.py[playerID] == "reinou")
        {
            if (bo.syokeii.tag == "banken" ||  bo.syokeii.tag == "zinrou" || bo.syokeii.tag == "reinourou" || bo.syokeii.tag == "syokuyoku" || bo.syokeii.tag == "zyurou" || bo.syokeii.tag == "husi" || bo.syokeii.tag == "nouaru")
            {
                Debug.Log("人狼");
            }
            else
            {
                Debug.Log("人狼ではない");
            }


        }











    }

}
