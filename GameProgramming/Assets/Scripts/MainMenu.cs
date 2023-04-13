using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;


public class MainMenu : MonoBehaviour
{
    public string startLevel;
    public GameObject settingMenu;
   public void SartGame()
   {
      
      PlayerPrefs.DeleteAll();
      PlayerPrefs.SetString("startLevel", startLevel);
      SceneManager.LoadScene("PreLoad");
   }
    public void SettingButton()
    {
        settingMenu.SetActive(true);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void BackButton()
    {
        settingMenu.SetActive(false);
    }
    public void CreditsButton()
    {
        SceneManager.LoadScene("credits");
    }
    public void ContinueButton()
    {
        SceneManager.LoadScene("SelectLvl");
    }
}