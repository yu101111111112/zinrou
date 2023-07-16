using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;



    public class uihyouzi : MonoBehaviourPunCallbacks


    {

        

        public Text[] botan;
        public int a = 0;
        public int b = 0;

        public GameObject[] subete;
        public string namE;



        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            subete = GameObject.FindGameObjectsWithTag("player");
            int count = subete.Length - 1;
           



















        }

   /* public override void OnConnectedToMaster()
    {
        int countt = botan.Length - 1;
       
        if (countt >= b)
        {



            foreach (var player in PhotonNetwork.PlayerList)
            {

                namE = player.NickName;
                Debug.Log(player.NickName);

                botan[b].text = namE;

                b = b + 1;
            }



           


        }


      
    }*/
     public override void OnJoinedRoom()
    {
        int countt = botan.Length - 1;
       
        if (countt >= b)
        {



            foreach (var player in PhotonNetwork.PlayerList)
            {

                namE = player.NickName;
                Debug.Log(player.NickName);

                botan[b].text = namE;

                b = b + 1;
            }



           


        }


      
    }
   public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        int countt = botan.Length - 1;
       
        if (countt >= b)
        {



          

                namE = newPlayer.NickName;
                Debug.Log(newPlayer.NickName);

                botan[b].text = namE;

                b = b + 1;
            



           


        }


      
    }
   



    }




