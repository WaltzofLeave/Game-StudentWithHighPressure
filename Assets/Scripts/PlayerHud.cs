using UnityEngine;

/*
 * On screen HUD to display current health.
 */
public class PlayerHud : MonoBehaviour
{
  private PlayerController playerController;
  private Texture2D halfHeart;
  private Texture2D heart;

  /*
   * Load and store the heart images and cache the PlayerController
   * component for later.
   */
  private void Start()
  {
    playerController = GetComponent<PlayerController>();
    heart = Resources.Load<Texture2D>("heart");
    halfHeart = Resources.Load<Texture2D>("halfHeart");
  }
   private void drawheart(int number)
   {
        int x = 10, y = 10, width = 50, height = 50;
        while (number !=0)
       {
            if(number >= 2)
            {
                GUI.DrawTexture(new Rect(x, y, width, height),heart);
                number -= 2;
            }
            else
            {
                GUI.DrawTexture(new Rect(x, y, width, height), halfHeart);
                number -= 1;
            }
            x += 50;
       }
   }
   private void showscore()
    {
        GUIStyle style = new GUIStyle();
        style.fontSize = 50;
        style.normal.textColor = new Color(0, 2, 4);
        GUI.Label(new Rect(10, 60, 100, 100), "Score: "+playerController.GetScore(),style);
        
    }
  /*
   * Using the current health from the PlayerController, display the
   * correct number of hearts and half hearts.
   */
  private void OnGUI()
  {
        /*
    if(playerController.GetHealth() == 6)
    {
      GUI.DrawTexture(new Rect(10, 10, 50, 50), heart);
      GUI.DrawTexture(new Rect(60, 10, 50, 50), heart);
      GUI.DrawTexture(new Rect(110, 10, 50, 50), heart);
    }
    else if(playerController.GetHealth() == 5)
    {
      GUI.DrawTexture(new Rect(10, 10, 50, 50), heart);
      GUI.DrawTexture(new Rect(60, 10, 50, 50), heart);
      GUI.DrawTexture(new Rect(110, 10, 50, 50), halfHeart);
    }
    else if(playerController.GetHealth() == 4)
    {
      GUI.DrawTexture(new Rect(10, 10, 50, 50), heart);
      GUI.DrawTexture(new Rect(60, 10, 50, 50), heart);
    }
    else if(playerController.GetHealth() == 3)
    {
      GUI.DrawTexture(new Rect(10, 10, 50, 50), heart);
      GUI.DrawTexture(new Rect(60, 10, 50, 50), halfHeart);
    }
    else if(playerController.GetHealth() == 2)
    {
      GUI.DrawTexture(new Rect(10, 10, 50, 50), heart);
    }
    else if(playerController.GetHealth() == 1)
    {
      GUI.DrawTexture(new Rect(10, 10, 50, 50), halfHeart);
    }*/
        drawheart(playerController.GetHealth());
        showscore();
    }
}
