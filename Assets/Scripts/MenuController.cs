using UnityEngine;

/*
 * Small behaviour to handle menu button callbacks.
 */
public class MenuController : MonoBehaviour
{
  /*
   * When the start button is pressed, load the Game scene.
   */
  public void OnStartClicked()
  {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
        //Application.LoadLevel("Game");
  }

  /*
   * When the back button is clicked, load the Menu scene.
   */
  public void OnBackClicked()
  {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
        //Application.LoadLevel("Menu");
  }
  public void OnExitClicked()
    {
        Application.Quit();
    }
}
