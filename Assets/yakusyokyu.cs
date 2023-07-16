using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class yakusyokyu : MonoBehaviourPunCallbacks
{






public int simin;
public int uranai;
public int reinou;
public int kariudo;
public int panya;
public int nekomata;
public int kaitou;
public int sityou;
public int dokusai;
public int nitouryuu;
public int ousama;
public int atotugi;
public int noroware;
public int buki;
public int bougu;
public int hutago;
public int isya;
public int banken;
public int tyourou;
public int ookamiwaki;
public int niseuranai;
public int hikari;
public int sinbun;
public int kenzya;
public int itako;
public int kaunsera;
public int toubou;
public int miko;
public int sinpu;
public int seisyoku;









public int zinrou;
public int kyouzin;
public int kyousin;
public int kuroneko;
public int tairou;
public int reinourou;
public int sasori;
public int gyanbura;
public int kariudokira;
public int syokuyoku;
public int zyurou;
public int mazyutusi;
public int husi;
public int noroi;
public int yami;
public int nouaru;
public int sagisi;
public int zyuzyutusi;
public int saiko;









public int kitune;
public int haisinsya;
public int kogitune;








public int zonbi;
public int zonbimania;





public int qp;
public int zyunai;
public int teruteru;
public int nekoaikouka;





public int koibito;
public int yopparai;





public GameObject[] playerS;
bool yakusyokukubari = false;



    public Dictionary<int, string> py = new Dictionary<int, string>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    
          playerS = GameObject.FindGameObjectsWithTag("player");
      
        if(Input.GetKeyDown(KeyCode.L))
        {


          yakusyokukubari = true;


         





        }
    
            











            if(yakusyokukubari == true && simin > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "simin";
           
                py.Add(playerS[a].GetComponent<PhotonView>().Owner.ActorNumber, "simin");
            
            
            
            }
             if(yakusyokukubari == true && uranai > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "uranai";
            uranai = uranai - 1;
          
            
                py.Add(playerS[a].GetComponent<PhotonView>().Owner.ActorNumber, "uranai");
            
           

        }
             if(yakusyokukubari == true && reinou > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "reinou";
            reinou = reinou - 1;
            py.Add(playerS[a].GetComponent<PhotonView>().Owner.ActorNumber, "reinou");
        }
             if(yakusyokukubari == true && kariudo > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "kariudo";
            kariudo = kariudo - 1;

            }
             if(yakusyokukubari == true && panya > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "panya";
            panya = panya - 1;

            }
             if(yakusyokukubari == true && nekomata > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "nekomata";
            nekomata = nekomata - 1;

            }
             if(yakusyokukubari == true && kaitou > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "kaitou";
            kaitou = kaitou - 1;

            }
             if(yakusyokukubari == true && sityou > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "sityou";
            sityou = sityou - 1;

            }
             if(yakusyokukubari == true && dokusai > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "dokusai";
            dokusai = dokusai - 1;

            }
             if(yakusyokukubari == true && nitouryuu > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "nitouryuu";
            nitouryuu = nitouryuu - 1;

            }
             if(yakusyokukubari == true && ousama > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "ousama";
            ousama = ousama - 1;

            }
             if(yakusyokukubari == true && atotugi > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "atotugi";
            atotugi = atotugi - 1;

            }
             if(yakusyokukubari == true && noroware > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "noroware";
            noroware = noroware - 1;

            }
             if(yakusyokukubari == true && buki > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "buki";
            buki = buki - 1;

            }
             if(yakusyokukubari == true && bougu > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "bougu";
            bougu = bougu - 1;

            }
             if(yakusyokukubari == true && hutago > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "hutago";
            hutago = hutago - 1;

            }
             if(yakusyokukubari == true && isya > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "isya";
            isya = isya - 1;

            }
             if(yakusyokukubari == true && banken > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "banken";
            banken = banken - 1;

            }
             if(yakusyokukubari == true && tyourou > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "tyourou";
            tyourou = tyourou - 1;

            }
             if(yakusyokukubari == true && ookamiwaki > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "ookamiwaki";
            ookamiwaki = ookamiwaki - 1;

            }
             if(yakusyokukubari == true && niseuranai > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "niseuranai";
            niseuranai = niseuranai - 1;

            }
             if(yakusyokukubari == true && zinrou > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "zinrou";
            zinrou = zinrou - 1;
            py.Add(playerS[a].GetComponent<PhotonView>().Owner.ActorNumber, "zinrou");

        }
             if(yakusyokukubari == true && kyouzin > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "kyouzin";
            kyouzin = kyouzin - 1;

            }
             if(yakusyokukubari == true && kyousin > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "kyousin";
            kyousin = kyousin - 1;

            }
             if(yakusyokukubari == true && kuroneko > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "kuroneko";
            kuroneko = kuroneko - 1;

            }
             if(yakusyokukubari == true && tairou > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "tairou";
            tairou = tairou - 1;

            }
             if(yakusyokukubari == true && reinourou > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "reinourou";
            reinourou = reinourou - 1;

            }
             if(yakusyokukubari == true && sasori > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "sasori";
            sasori = sasori - 1;

            }
             if(yakusyokukubari == true && gyanbura > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "gyanbura";
            gyanbura = gyanbura - 1;

            }
             if(yakusyokukubari == true && kariudokira > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "kariudokira";
            kariudokira = kariudokira - 1;

            }
             if(yakusyokukubari == true && syokuyoku > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "syokuyoku";
            syokuyoku = syokuyoku - 1;

            }
             if(yakusyokukubari == true && zyurou > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "zyurou";
            zyurou = zyurou - 1;

            }
             if(yakusyokukubari == true && mazyutusi > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "mazyutusi";
            mazyutusi = mazyutusi - 1;

            }
             if(yakusyokukubari == true && husi > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "husi";
            husi = husi - 1;

            }
             if(yakusyokukubari == true && noroi > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "noroi";
            noroi = noroi - 1;

            }
             if(yakusyokukubari == true && kitune > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "kitune";
            kitune = kitune - 1;

            }
             if(yakusyokukubari == true && haisinsya > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "haisinsya";
            haisinsya = haisinsya - 1;

            }
             if(yakusyokukubari == true && zonbi > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "zonbi";
            zonbi = zonbi - 1;

            }
             if(yakusyokukubari == true && qp > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "qp";
            qp = qp - 1;

            }
             if(yakusyokukubari == true && zyunai > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "zyunai";
            zyunai = zyunai - 1;

            }
             if(yakusyokukubari == true && teruteru > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "teruteru";
            teruteru = teruteru - 1;

            }
             if(yakusyokukubari == true && nekoaikouka > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "nekoaikouka";
            nekoaikouka = nekoaikouka - 1;

            }
             if(yakusyokukubari == true && zyuzyutusi > 0)
            {
            int a = Random.Range (0, playerS.Length);
            playerS[a].gameObject.tag = "zyuzyutusi";
            zyuzyutusi = zyuzyutusi - 1;

            }
        if (yakusyokukubari == true && sinbun > 0)
        {
            int a = Random.Range(0, playerS.Length);
            playerS[a].gameObject.tag = "sinbun";
            sinbun = sinbun - 1;

        }
        if (yakusyokukubari == true && kenzya > 0)
        {
            int a = Random.Range(0, playerS.Length);
            playerS[a].gameObject.tag = "kenzya";
            kenzya = kenzya - 1;

        }
        if (yakusyokukubari == true && itako > 0)
        {
            int a = Random.Range(0, playerS.Length);
            playerS[a].gameObject.tag = "itako";
            itako = itako - 1;

        }
        if (yakusyokukubari == true && kaunsera > 0)
        {
            int a = Random.Range(0, playerS.Length);
            playerS[a].gameObject.tag = "kaunsera";
            kaunsera = kaunsera - 1;

        }
        if (yakusyokukubari == true && toubou > 0)
        {
            int a = Random.Range(0, playerS.Length);
            playerS[a].gameObject.tag = "toubou";
            toubou = toubou - 1;

        }
        if (yakusyokukubari == true && miko > 0)
        {
            int a = Random.Range(0, playerS.Length);
            playerS[a].gameObject.tag = "miko";
            miko = miko - 1;

        }
        if (yakusyokukubari == true && sinpu > 0)
        {
            int a = Random.Range(0, playerS.Length);
            playerS[a].gameObject.tag = "sinpu";
            sinpu = sinpu - 1;

        }
        if (yakusyokukubari == true && seisyoku > 0)
        {
            int a = Random.Range(0, playerS.Length);
            playerS[a].gameObject.tag = "seisyoku";
            seisyoku = seisyoku - 1;

        }
        if (yakusyokukubari == true && nouaru > 0)
        {
            int a = Random.Range(0, playerS.Length);
            playerS[a].gameObject.tag = "nouaru";
            nouaru = nouaru - 1;

        }
        if (yakusyokukubari == true && sagisi > 0)
        {
            int a = Random.Range(0, playerS.Length);
            playerS[a].gameObject.tag = "sagisi";
            sagisi = sagisi - 1;

        }
        if (yakusyokukubari == true && kogitune > 0)
        {
            int a = Random.Range(0, playerS.Length);
            playerS[a].gameObject.tag = "kogitune";
            kogitune = kogitune - 1;

        }
        if (yakusyokukubari == true && zonbimania > 0)
        {
            int a = Random.Range(0, playerS.Length);
            playerS[a].gameObject.tag = "zonbimania";
            zonbimania = zonbimania - 1;

        }
        if (yakusyokukubari == true && saiko > 0)
        {

            int a = Random.Range(0, playerS.Length);
            playerS[a].gameObject.tag = "saiko";
            saiko = saiko - 1;

        }
    }
}
