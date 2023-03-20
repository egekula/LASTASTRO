using System;
using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;


public class UIManager : MonoBehaviour
{
    // Sahnedeki tüm UI ögelerini tutacak bir dizi

    public GameObject sound_on;
    public GameObject sound_off;
    public GameObject noAds;
    public TextMeshProUGUI touchtomove;
    public GameObject shop;
    public GameObject theAstronautText;
    public GameObject soundOnOffButon;
    [SerializeField] private AudioSource buttonSong;
    public GameObject restartButton;
    public PlayerController playerController;
    public TextMeshProUGUI softStarText;
    public GameObject starImage;
    public AdManager adManager;
    [SerializeField] private float waitsSecond;

    private void Start()
    {
        playerController.softStarScore = PlayerPrefs.GetInt("coin");
        //playerController.softStarScore = 100000;
        if (PlayerPrefs.HasKey("Sound")==false)
        {
            PlayerPrefs.SetInt("Sound", 1);
        }

        

        if (PlayerPrefs.GetInt("Noads") == 1)
        {
            NoAdsRemove();
        }
    }

    private void Update()
    {
        softStarText.text = playerController.softStarScore.ToString();
        PlayerPrefs.SetInt("coin",playerController.softStarScore);
    }

    // Dokunuş algılandığında çalışacak fonksiyon
    public void FirstTouch()
    {
        sound_on.SetActive(false);
        sound_off.SetActive(false);
        noAds.SetActive(false);
        Destroy(touchtomove);
        shop.SetActive(false);
        theAstronautText.SetActive(false);
        soundOnOffButon.SetActive((false));
        starImage.SetActive(false);
        Destroy(softStarText);
    }

    public void RestartButtonActive()
    {
        restartButton.SetActive(true);
        playerController.highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        //playerController.scoretext.text = playerController.score.ToString();
        playerController.scoreCopy.text = playerController.score.ToString();
        StartCoroutine(WaitAdd());
        Screen.SetResolution(Screen.currentResolution.width*2,Screen.currentResolution.height*2,true);


    }

    public void RestartScene()
    { 
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    /*public void Save()
    {
        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            sound_on.SetActive(true);
            sound_off.SetActive(false);
            AudioListener.volume = 1;
        }
        else if (PlayerPrefs.GetInt("Sound") == 2)
        {
            sound_on.SetActive(false);
            sound_off.SetActive(true);
            AudioListener.volume =0;
        }
    }*/



    public void Sound_Open()
    {
        sound_on.SetActive(false);
        sound_off.SetActive(true);
        AudioListener.volume = 0;
        PlayerPrefs.SetInt("Sound", 2);

    }

    public void Sound_Off()
    {
        sound_on.SetActive(true);
        sound_off.SetActive(false);
        AudioListener.volume = 1;
        PlayerPrefs.SetInt("Sound", 1);
    }

    public void NoAdsRemove()
    {
        Destroy(noAds);
    }
    

    public void ButtonSong()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            buttonSong.Play();
        } 
    }

    private IEnumerator WaitAdd()
    {
        yield return new WaitForSeconds(waitsSecond);
        adManager.RequestInterstitial();
        adManager.ShowInterstitial();

    }

}
