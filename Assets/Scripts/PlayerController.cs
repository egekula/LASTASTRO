using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.EventSystems;
public class PlayerController : MonoBehaviour
{
    public Vector3 astronautDirection;
    [SerializeField] private float astronautSpeed;
    public TextMeshProUGUI scoretext;
    public int score = 0;
    public Animator myAnimator;
    private float addedSpeed=0.3f;
    private int x=50;
    public UIManager uiManager;
    [SerializeField]private AudioSource astronautVoice;
    [SerializeField] private AudioClip tapSong;
    [SerializeField] private AudioClip deadSong;
    [SerializeField] private AudioClip starSong;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI scoreCopy;
    public int softStarScore;
    

    private void Awake()
    {
        astronautDirection = Vector3.zero;
        myAnimator = GetComponent<Animator>();
        myAnimator.SetTrigger("Idle");
        Screen.SetResolution(Screen.currentResolution.width/2,Screen.currentResolution.height/2,true);

    }

    private void Update()
    {
        GetAstronautInput();
        SetAstronautMovement();
        
    }

    private void GetAstronautInput()
    {
        if(transform.position.y>= 0.75 && transform.position.y <= 0.79f) 
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                {
                    uiManager.FirstTouch();
                    score++;
                    SetCountText();
                    ChangeDirectionAstronaut();
                    myAnimator.SetTrigger("Running");
                    astronautVoice.PlayOneShot(tapSong);
                }
                uiManager.ButtonSong();
            }
        }
        if(transform.position.y<0.6f && transform.position.y>-0.2f)
        {
            astronautVoice.PlayOneShot(deadSong);
            
        }
        else if(transform.position.y<=-10f)
        {
            Destroy();
        }

        while (score >= x)
        {
            astronautSpeed += addedSpeed;
            x += 50;
        }
        
    }

    private void ChangeDirectionAstronaut()
    {
        if (astronautDirection.x == -1)
        {
            astronautDirection = Vector3.forward;
            transform.rotation = Quaternion.LookRotation(Vector3.forward);
        }
        else
        {
            astronautDirection = Vector3.left;
            transform.rotation = Quaternion.LookRotation(Vector3.left);
        }
    }

    private void SetAstronautMovement()
    {
        transform.position += astronautDirection * (astronautSpeed * Time.deltaTime);
    }
    private void SetCountText()
    {
        scoretext.text = score.ToString();
        scoreCopy.text = scoretext.text;
        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore",score);
        }
    }
    private void Destroy()
    {
        if (transform.position.y <= -30f)
        {
            gameObject.SetActive(false);
            uiManager.RestartButtonActive();
            Destroy(scoretext);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Asteroid"))
        {
            astronautVoice.PlayOneShot(starSong);
            other.gameObject.SetActive(false);
            softStarScore += 1;
            score += 2;
            SetCountText();
        }
    }

}
