using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public PlayerController playerController;
    public GameObject particle1;
    public GameObject particle2;
    public GameObject particle3;
    public GameObject particle4;
    public GameObject particle5;
    public GameObject particle6;
    public GameObject particle7;
    public GameObject particle8;
    public GameObject particle9;


    public Sprite YellowImage;
    public Sprite GreenImage;

    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject item5;
    public GameObject item6;
    public GameObject item7;
    public GameObject item8;
    public GameObject item9;

    public GameObject lock1;
    public GameObject lock2;
    public GameObject lock3;
    public GameObject lock4;
    public GameObject lock5;
    public GameObject lock6;
    public GameObject lock7;
    public GameObject lock8;

    public TextMeshProUGUI moneytext1;
    public TextMeshProUGUI moneytext2;
    public TextMeshProUGUI moneytext3;
    public TextMeshProUGUI moneytext4;
    public TextMeshProUGUI moneytext5;
    public TextMeshProUGUI moneytext6;
    public TextMeshProUGUI moneytext7;
    public TextMeshProUGUI moneytext8;
    

    public void Awake()
    {
        if (PlayerPrefs.HasKey("itemselect") == false)
        {
            PlayerPrefs.SetInt("itemselect",0);
        }

        if (PlayerPrefs.GetInt("itemselect") == 0)
        {
            ItemOpen();
        }
        else if (PlayerPrefs.GetInt("itemselect") == 1)
        {
            ItemOpen2();
            
        }
        else if (PlayerPrefs.GetInt("itemselect") == 2)
        {
            ItemOpen3();
            
        }
        else if (PlayerPrefs.GetInt("itemselect") == 3)
        {
            ItemOpen4();
            
        }
        else if (PlayerPrefs.GetInt("itemselect") == 4)
        {
            ItemOpen5();
            
        }
        else if (PlayerPrefs.GetInt("itemselect") == 5)
        {
            ItemOpen6();
            
        }
        else if (PlayerPrefs.GetInt("itemselect") == 6)
        {
            ItemOpen7();
            
        }
        else if (PlayerPrefs.GetInt("itemselect") == 7)
        {
            ItemOpen8();
            
        }
        else if (PlayerPrefs.GetInt("itemselect") == 8)
        {
            ItemOpen9();
            
        }
        
        if (PlayerPrefs.HasKey("lock1control")== false)
        {
            PlayerPrefs.SetInt("lock1control",0);
        }

        if (PlayerPrefs.HasKey("lock2control") == false)
        {
            PlayerPrefs.SetInt("lock2control",0);
        }

        if (PlayerPrefs.HasKey("lock3control") == false)
        {
            PlayerPrefs.SetInt("lock3control",0);
        }
        if (PlayerPrefs.HasKey("lock4control") == false)
        {
            PlayerPrefs.SetInt("lock4control",0);
        }
        if (PlayerPrefs.HasKey("lock5control") == false)
        {
            PlayerPrefs.SetInt("lock5control",0);
        }
        if (PlayerPrefs.HasKey("lock6control") == false)
        {
            PlayerPrefs.SetInt("lock6control",0);
        }
        if (PlayerPrefs.HasKey("lock7control") == false)
        {
            PlayerPrefs.SetInt("lock7control",0);
        }
        if (PlayerPrefs.HasKey("lock8control") == false)
        {
            PlayerPrefs.SetInt("lock8control",0);
        }

        if (PlayerPrefs.GetInt("lock1control") == 1)
        {
            lock1.SetActive(false);
        }
        if (PlayerPrefs.GetInt("lock2control") == 1)
        {
            lock2.SetActive(false);
        }
        if (PlayerPrefs.GetInt("lock3control") == 1)
        {
            lock3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("lock4control") == 1)
        {
            lock4.SetActive(false);
        }
        if (PlayerPrefs.GetInt("lock5control") == 1)
        {
            lock5.SetActive(false);
        }
        if (PlayerPrefs.GetInt("lock6control") == 1)
        {
            lock6.SetActive(false);
        }
        if (PlayerPrefs.GetInt("lock7control") == 1)
        {
            lock7.SetActive(false);
        }
        if (PlayerPrefs.GetInt("lock8control") == 1)
        {
            lock8.SetActive(false);
        }
        /*if (PlayerPrefs.HasKey("textdestroy1") == false)
        {
            PlayerPrefs.SetInt("textdestroy1",1);
        }
        if (PlayerPrefs.HasKey("textdestroy2") == false)
        {
            PlayerPrefs.SetInt("textdestroy2",1);
        }
        if (PlayerPrefs.GetInt("textdestroy1") == 0)
        {
            Destroy(moneytext1);
        }
        if (PlayerPrefs.GetInt("textdestroy2") == 0)
        {
            Destroy(moneytext2);
        }*/
        
    }

    public void ItemOpen()
    {
        particle1.SetActive(true);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);
        particle7.SetActive(false);
        particle8.SetActive(false);
        particle9.SetActive(false);

        item1.GetComponent<Image>().sprite = GreenImage;
        item2.GetComponent<Image>().sprite = YellowImage;
        item3.GetComponent<Image>().sprite = YellowImage;
        item4.GetComponent<Image>().sprite = YellowImage;
        item5.GetComponent<Image>().sprite = YellowImage;
        item6.GetComponent<Image>().sprite = YellowImage;
        item7.GetComponent<Image>().sprite = YellowImage;
        item8.GetComponent<Image>().sprite = YellowImage;
        item9.GetComponent<Image>().sprite = YellowImage;
        
        PlayerPrefs.SetInt("itemselect",0);
    }
    
    public void ItemOpen2()
    {
        particle1.SetActive(false);
        particle2.SetActive(true);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);
        particle7.SetActive(false);
        particle8.SetActive(false);
        particle9.SetActive(false);
        

        item1.GetComponent<Image>().sprite = YellowImage;
        item2.GetComponent<Image>().sprite = GreenImage;
        item3.GetComponent<Image>().sprite = YellowImage;
        item4.GetComponent<Image>().sprite = YellowImage;
        item5.GetComponent<Image>().sprite = YellowImage;
        item6.GetComponent<Image>().sprite = YellowImage;
        item7.GetComponent<Image>().sprite = YellowImage;
        item8.GetComponent<Image>().sprite = YellowImage;
        item9.GetComponent<Image>().sprite = YellowImage;
        
        PlayerPrefs.SetInt("itemselect",1);
        
    }
    
    public void ItemOpen3()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(true);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);
        particle7.SetActive(false);
        particle8.SetActive(false);
        particle9.SetActive(false);
        
        
        item1.GetComponent<Image>().sprite = YellowImage;
        item2.GetComponent<Image>().sprite = YellowImage;
        item3.GetComponent<Image>().sprite = GreenImage;
        item4.GetComponent<Image>().sprite = YellowImage;
        item5.GetComponent<Image>().sprite = YellowImage;
        item6.GetComponent<Image>().sprite = YellowImage;
        item7.GetComponent<Image>().sprite = YellowImage;
        item8.GetComponent<Image>().sprite = YellowImage;
        item9.GetComponent<Image>().sprite = YellowImage;
        
        PlayerPrefs.SetInt("itemselect",2);
        
    }
    
    public void ItemOpen4()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(true);
        particle5.SetActive(false);
        particle6.SetActive(false);
        particle7.SetActive(false);
        particle8.SetActive(false);
        particle9.SetActive(false);
        

        item1.GetComponent<Image>().sprite = YellowImage;
        item2.GetComponent<Image>().sprite = YellowImage;
        item3.GetComponent<Image>().sprite = YellowImage;
        item4.GetComponent<Image>().sprite = GreenImage;
        item5.GetComponent<Image>().sprite = YellowImage;
        item6.GetComponent<Image>().sprite = YellowImage;
        item7.GetComponent<Image>().sprite = YellowImage;
        item8.GetComponent<Image>().sprite = YellowImage;
        item9.GetComponent<Image>().sprite = YellowImage;
        PlayerPrefs.SetInt("itemselect",3);
       

    }
    public void ItemOpen5()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(true);
        particle6.SetActive(false);
        particle7.SetActive(false);
        particle8.SetActive(false);
        particle9.SetActive(false);
        
        

        item1.GetComponent<Image>().sprite = YellowImage;
        item2.GetComponent<Image>().sprite = YellowImage;
        item3.GetComponent<Image>().sprite = YellowImage;
        item4.GetComponent<Image>().sprite = YellowImage;
        item5.GetComponent<Image>().sprite = GreenImage;
        item6.GetComponent<Image>().sprite = YellowImage;
        item7.GetComponent<Image>().sprite = YellowImage;
        item8.GetComponent<Image>().sprite = YellowImage;
        item9.GetComponent<Image>().sprite = YellowImage;
        
        PlayerPrefs.SetInt("itemselect",4);
       

    }
    public void ItemOpen6()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(true);
        particle7.SetActive(false);
        particle8.SetActive(false);
        particle9.SetActive(false);
        

        item1.GetComponent<Image>().sprite = YellowImage;
        item2.GetComponent<Image>().sprite = YellowImage;
        item3.GetComponent<Image>().sprite = YellowImage;
        item4.GetComponent<Image>().sprite = YellowImage;
        item5.GetComponent<Image>().sprite = YellowImage;
        item6.GetComponent<Image>().sprite = GreenImage;
        item7.GetComponent<Image>().sprite = YellowImage;
        item8.GetComponent<Image>().sprite = YellowImage;
        item9.GetComponent<Image>().sprite = YellowImage;
        PlayerPrefs.SetInt("itemselect",5);
       

    }
    public void ItemOpen7()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);
        particle7.SetActive(true);
        particle8.SetActive(false);
        particle9.SetActive(false);
        

        item1.GetComponent<Image>().sprite = YellowImage;
        item2.GetComponent<Image>().sprite = YellowImage;
        item3.GetComponent<Image>().sprite = YellowImage;
        item4.GetComponent<Image>().sprite = YellowImage;
        item5.GetComponent<Image>().sprite = YellowImage;
        item6.GetComponent<Image>().sprite = YellowImage;
        item7.GetComponent<Image>().sprite = GreenImage;
        item8.GetComponent<Image>().sprite = YellowImage;
        item9.GetComponent<Image>().sprite = YellowImage;
        PlayerPrefs.SetInt("itemselect",6);
       

    }
    public void ItemOpen8()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);
        particle7.SetActive(false);
        particle8.SetActive(true);
        particle9.SetActive(false);
        

        item1.GetComponent<Image>().sprite = YellowImage;
        item2.GetComponent<Image>().sprite = YellowImage;
        item3.GetComponent<Image>().sprite = YellowImage;
        item4.GetComponent<Image>().sprite = YellowImage;
        item5.GetComponent<Image>().sprite = YellowImage;
        item6.GetComponent<Image>().sprite = YellowImage;
        item7.GetComponent<Image>().sprite = YellowImage;
        item8.GetComponent<Image>().sprite = GreenImage;
        item9.GetComponent<Image>().sprite = YellowImage;
        PlayerPrefs.SetInt("itemselect",7);
       

    }
    public void ItemOpen9()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);
        particle7.SetActive(false);
        particle8.SetActive(false);
        particle9.SetActive(true);
        

        item1.GetComponent<Image>().sprite = YellowImage;
        item2.GetComponent<Image>().sprite = YellowImage;
        item3.GetComponent<Image>().sprite = YellowImage;
        item4.GetComponent<Image>().sprite = YellowImage;
        item5.GetComponent<Image>().sprite = YellowImage;
        item6.GetComponent<Image>().sprite = YellowImage;
        item7.GetComponent<Image>().sprite = YellowImage;
        item8.GetComponent<Image>().sprite = YellowImage;
        item9.GetComponent<Image>().sprite = GreenImage;
        PlayerPrefs.SetInt("itemselect",8);
       

    }

    public void LockOpen1()
    {
        int money = PlayerPrefs.GetInt("coin");
        int lock1control = PlayerPrefs.GetInt("lock1control");
        //int destroytextcontrol1 = PlayerPrefs.GetInt("textdestroy1");
        if (money >= 1000 && lock1control == 0 /*&& destroytextcontrol1 == 1*/)
        {
            lock1.SetActive(false);
            PlayerPrefs.SetInt("coin",money - 1000);
            PlayerPrefs.SetInt("lock1control",1);
            //PlayerPrefs.SetInt("textdestroy1",0);
            ItemOpen2();
            playerController.softStarScore = PlayerPrefs.GetInt("coin");
            
        }
    }
    public void LockOpen2()
    {
        int money = PlayerPrefs.GetInt("coin");
        int lock2control = PlayerPrefs.GetInt("lock2control");
        //int destroytextcontrol2 = PlayerPrefs.GetInt("textdestroy2");
        if (money >= 1000 && lock2control == 0 /*&& destroytextcontrol2 ==1*/)
        {
            lock2.SetActive(false);
            PlayerPrefs.SetInt("coin",money - 1000);
            PlayerPrefs.SetInt("lock2control",1);
            //PlayerPrefs.SetInt("textdestroy2",0);
            ItemOpen3();
            playerController.softStarScore = PlayerPrefs.GetInt("coin");
            
        }
        
    }
    public void LockOpen3()
    {
        int money = PlayerPrefs.GetInt("coin");
        int lock3control = PlayerPrefs.GetInt("lock3control");

        if (money >= 2500 && lock3control == 0)
        {
            lock3.SetActive(false);
            PlayerPrefs.SetInt("coin",money - 2500);
            PlayerPrefs.SetInt("lock3control",1);
            ItemOpen4();
            playerController.softStarScore = PlayerPrefs.GetInt("coin");
            
        }
        
    }
    public void LockOpen4()
    {
        int money = PlayerPrefs.GetInt("coin");
        int lock4control = PlayerPrefs.GetInt("lock4control");

        if (money >= 2500 && lock4control == 0)
        {
            lock4.SetActive(false);
            PlayerPrefs.SetInt("coin",money - 2500);
            PlayerPrefs.SetInt("lock4control",1);
            ItemOpen5();
            playerController.softStarScore = PlayerPrefs.GetInt("coin");
            
        }
        
    }
    public void LockOpen5()
    {
        int money = PlayerPrefs.GetInt("coin");
        int lock5control = PlayerPrefs.GetInt("lock5control");

        if (money >= 2500 && lock5control == 0)
        {
            lock5.SetActive(false);
            PlayerPrefs.SetInt("coin",money - 2500);
            PlayerPrefs.SetInt("lock5control",1);
            ItemOpen6();
            playerController.softStarScore = PlayerPrefs.GetInt("coin");
            
        }
        
    }
    public void LockOpen6()
    {
        int money = PlayerPrefs.GetInt("coin");
        int lock6control = PlayerPrefs.GetInt("lock6control");

        if (money >= 2500 && lock6control == 0)
        {
            lock6.SetActive(false);
            PlayerPrefs.SetInt("coin",money - 2500);
            PlayerPrefs.SetInt("lock6control",1);
            ItemOpen7();
            playerController.softStarScore = PlayerPrefs.GetInt("coin");
            
        }
        
    }
    public void LockOpen7()
    {
        int money = PlayerPrefs.GetInt("coin");
        int lock7control = PlayerPrefs.GetInt("lock7control");

        if (money >= 2500 && lock7control == 0)
        {
            lock7.SetActive(false);
            PlayerPrefs.SetInt("coin",money - 2500);
            PlayerPrefs.SetInt("lock7control",1);
            ItemOpen8();
            playerController.softStarScore = PlayerPrefs.GetInt("coin");
            
        }
        
    }
    public void LockOpen8()
    {
        int money = PlayerPrefs.GetInt("coin");
        int lock8control = PlayerPrefs.GetInt("lock8control");

        if (money >= 5000 && lock8control == 0)
        {
            lock8.SetActive(false);
            PlayerPrefs.SetInt("coin",money - 5000);
            PlayerPrefs.SetInt("lock8control",1);
            ItemOpen9();
            playerController.softStarScore = PlayerPrefs.GetInt("coin");
            
        }
        
    }
}
