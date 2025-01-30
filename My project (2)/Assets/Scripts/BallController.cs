using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    int speed;
    bool isGameStarted;
    public GameObject mainMenuPanel;
    public GameObject failMenuPanel;
    public GameObject successMenuPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 4;
        rb = GetComponent<Rigidbody>();
        isGameStarted = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && isGameStarted == true)
        {
            if(rb != null)
            {
                //rb.velocity = Vector3.up * speed;
                rb.velocity = new Vector3(1, 1, 0) * speed;
                //rb.AddForce(Vector3.up * speed);
            }
        }
    } 

    //Top sütunu degidiginde restart butonun çıkması sağlanır
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            ShowFailedMenu();
            Time.timeScale = 0; //Bununla top durar ve havada kalır, oyun durar
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Finish")
        {
            ShowSuccessMenu();
            Time.timeScale = 0;
        }
    }

    //Start butonuna basildiginda panelin kalkmasini sagladi
    //isGameStarted true yaparak ise diger fonksiyonlar calisti
    public void StartButtonTapped()
    {
        mainMenuPanel.SetActive(false);
        isGameStarted = true;
    }

    public void RestartButtonTapped()
    {
        failMenuPanel.SetActive(false);
        Time.timeScale = 1; //Durdurulan zamanı tekrardan baslattık
        SceneManager.LoadScene("SampleScene");
    }

    private void ShowFailedMenu()
    {
        failMenuPanel.SetActive(true);
        isGameStarted = false;
    }

    private void ShowSuccessMenu()
    {
        successMenuPanel.SetActive(true);
        isGameStarted = false;
    }


}
