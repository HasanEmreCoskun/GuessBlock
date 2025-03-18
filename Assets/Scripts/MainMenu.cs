using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Baþla butonu basýlýnca çalýþýr
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene"); // Oyun sahnesine geç
    }

    // Ayarlar butonu basýlýnca çalýþýr
    public void OpenSettings()
    {
        Debug.Log("Ayarlar menüsü açýlacak!");
    }

    // Çýkýþ butonu basýlýnca çalýþýr
    public void QuitGame()
    {
        Application.Quit(); // Oyunu kapat
        Debug.Log("Oyun kapatýldý! (Editor'de çalýþmaz)");
    }
}
