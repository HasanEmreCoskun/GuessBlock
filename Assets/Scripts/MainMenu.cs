using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Ba�la butonu bas�l�nca �al���r
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene"); // Oyun sahnesine ge�
    }

    // Ayarlar butonu bas�l�nca �al���r
    public void OpenSettings()
    {
        Debug.Log("Ayarlar men�s� a��lacak!");
    }

    // ��k�� butonu bas�l�nca �al���r
    public void QuitGame()
    {
        Application.Quit(); // Oyunu kapat
        Debug.Log("Oyun kapat�ld�! (Editor'de �al��maz)");
    }
}
