
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class nagare : MonoBehaviourPunCallbacks

    
{

    public botan bo;
    public int i = 0;
    int hbyouu = 30;
 
  int ybyouu = 60;

    public Text byousuu;

    public bool hanasiai = false;
    public bool yoru = false;
   public bool hanasiaii = false;
    public bool yoruu = false;


   



    public int hyoua = 0;
    public int hyoub = 0;
    public int hyouc = 0;
    public int hyoud = 0;
    public int hyoue = 0;
    public int hyouf = 0;
    public int hyoug = 0;
    public int hyouh = 0;
    public int hyoui = 0;
    public int hyouj = 0;
    public int hyouk = 0;
    public int hyoul = 0;
    public int hyoum = 0;
    public int hyoun = 0;
    public int hyouo = 0;
    public int hyoup = 0;
    public int hyouq = 0;
    public int hyour = 0;
    public int hyous = 0;
    public int hyout = 0;
  

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {



    if(Input.GetKeyDown(KeyCode.P))
{

  hanasiai = true;
  hanasiaii = true;


}
       if(hanasiai == true && hanasiaii == true)
{         StartCoroutine(ha());

hanasiaii = false;
}
if(hbyouu <= 0)
{ 
hanasiai = false;
yoru = true;
yoruu = true;
StartCoroutine(ha());
hbyouu = 300;


}
if(ybyouu <= 0)
{ 
yoru = false;
hanasiai = true;
hanasiaii = true;
StartCoroutine(yor());
ybyouu = 60;



}
 

    


    if(hanasiaii == true)
    {
    hyoua = 0;
    hyoub = 0;
    hyouc = 0;
    hyoud = 0;
    hyoue = 0;
    hyouf = 0;
    hyoug = 0;
    hyouh = 0;
    hyoui = 0;
    hyouj = 0;
    hyouk = 0;
    hyoul = 0;
    hyoum = 0;
    hyoun = 0;
    hyouo = 0;
    hyoup = 0;
    hyouq = 0;
    hyour = 0;
    hyous = 0;
    hyout = 0;
            bo.isClick = true;


    }
     if(yoruu == true)
    {
    hyoua = 0;
    hyoub = 0;
    hyouc = 0;
    hyoud = 0;
    hyoue = 0;
    hyouf = 0;
    hyoug = 0;
    hyouh = 0;
    hyoui = 0;
    hyouj = 0;
    hyouk = 0;
    hyoul = 0;
    hyoum = 0;
    hyoun = 0;
    hyouo = 0;
    hyoup = 0;
    hyouq = 0;
    hyour = 0;
    hyous = 0;
    hyout = 0;
            bo.isClick = true;


    }









    }
    private IEnumerator ha()
    {

    hbyouu = hbyouu - 1;
    byousuu.text = hbyouu.ToString();;
    yield return new WaitForSeconds(1);
    StartCoroutine(ha());




    }
    private IEnumerator yor()
    {

    ybyouu = ybyouu - 1;
    byousuu.text = ybyouu.ToString();;
    yield return new WaitForSeconds(1);
    StartCoroutine(yor());




    }






    public void Onclick1()
    {
        if (bo.isClick == true)
        {
            hyoua = hyoua + 1;
        }
    }
    public void Onclick2()
    {
        if (bo.isClick == true)
        {
            hyoub = hyoub + 1;
        }
    }
    public void Onclick3()
    {
        if (bo.isClick == true)
        {
            hyouc = hyouc + 1;
        }
    }
    public void Onclick4()
    {
        if (bo.isClick == true)
        {
            hyoud = hyoud + 1;
        }
    }
    public void Onclick5()
    {
        if (bo.isClick == true)
        {
            hyoue = hyoue + 1;
        }
    }
    public void Onclick6()
    {
        if (bo.isClick == true)
        {
            hyouf = hyouf + 1;
        }
    }
    public void Onclick7()
    {
        if (bo.isClick == true)
        {
            hyoug = hyoug + 1;
        }
    }
    public void Onclick8()
    {
        hyouh = hyouh + 1;
    }
    public void Onclick9()
    {
        if (bo.isClick == true)
        {
            hyoui = hyoui + 1;
        }
    }public void Onclick10()
    {
        if (bo.isClick == true)
        {
            hyouj = hyouj + 1;
        }
    }
    public void Onclick11()
    {
        if (bo.isClick == true)
        {
            hyouk = hyouk + 1;
        }
    }
    public void Onclick12()
    {
        if (bo.isClick == true)
        {
            hyoul = hyoul + 1;
        }
    }
    public void Onclick13()
    {
        if (bo.isClick == true)
        {
            hyoum = hyoum + 1;
        }
    }
    public void Onclick14()
    {
        if (bo.isClick == true)
        {
            hyoun = hyoun + 1;
        }
    }
    public void Onclick15()
    {
        if (bo.isClick == true)
        {
            hyouo = hyouo + 1;
        }
    }
    public void Onclick16()
    {
        if (bo.isClick == true)
        {
            hyoup = hyoup + 1;
        }
    }
    public void Onclick17()
    {
        if (bo.isClick == true)
        {
            hyouq = hyouq + 1;
        }
    }
    public void Onclick18()
    {
        if (bo.isClick == true)
        {
            hyour = hyour + 1;
        }
    }
    public void Onclick19()
    {
        if (bo.isClick == true)
        {
            hyous = hyous + 1;
        }
    }
      public void Onclick20()
    {
        if (bo.isClick == true)
        {
            hyout = hyout + 1;
        }
    }


}
