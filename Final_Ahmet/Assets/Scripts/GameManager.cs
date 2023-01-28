using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    int coins = 0;
    [SerializeField] TextMeshProUGUI coinsText;
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins;

           

        }
        if (other.gameObject.name == "ball")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        

    } // Alt�n Toplama ve b�l�m ge�me kodlar�

    public void RulesGame()
    {
        SceneManager.LoadScene(5);
    } // Oyunun Kurallar� sayfas�
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    } // Oyuna Ba�lama

    public void Back()
    {
        SceneManager.LoadScene(0);
    }  // Ana Men�
    




}
