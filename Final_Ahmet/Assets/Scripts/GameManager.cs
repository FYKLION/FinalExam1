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
        

    } // Altýn Toplama ve bölüm geçme kodlarý

    public void RulesGame()
    {
        SceneManager.LoadScene(5);
    } // Oyunun Kurallarý sayfasý
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    } // Oyuna Baþlama

    public void Back()
    {
        SceneManager.LoadScene(0);
    }  // Ana Menü
    




}
