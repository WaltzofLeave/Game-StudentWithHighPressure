using UnityEngine;

/*
 * Behaviour to handle keyboard input and also store the player's
 * current health.
 */
public class PlayerController : MonoBehaviour
{
  private Rigidbody2D rigidbody2d;
  private int health;
  private bool canJump;
    private int score ;
    private GetandSetLevel level;





    private AudioSource SoundPlayer ;
    private void PlaySound(string name)
    {
         AudioClip clip = Resources.Load<AudioClip>(name);
         SoundPlayer.clip = clip;
         SoundPlayer.PlayOneShot(clip);
    }
/*
 * Apply initial health and also store the Rigidbody2D reference for
 * future because GetComponent<T> is relatively expensive.
 */
private void Start()
  {
    health = 6;
        score = GetScoreFromSource();
    rigidbody2d = GetComponent<Rigidbody2D>();
        level = GameObject.Find("Level").GetComponent<GetandSetLevel>();
    }

  /*
   * Remove one health unit from player and if health becomes 0, change
   * scene to the end game scene.
   */
  public void Damage()
  {
    health -= 1;

    if(health < 1)
    {
            level.clearlevel();
            ClearSourceScore();
            UnityEngine.SceneManagement.SceneManager.LoadScene("EndGame");
            // Application.LoadLevel("EndGame");
    }
        this.GetComponent<AudioSource>().Play();
  }

  /*
   * Accessor for health variable, used by he HUD to display health.
   */
  public int GetHealth()
  {
    return health;
  }

   public int GetScore()
    {
        return score;
    }
    public void AddScore()
    {
        score += 10;
        SetScoreToSource(score);
    }
    private int GetScoreFromSource()
    {
        return GameObject.Find("Score").GetComponent<ScoreManager>().GetScore();
    }
    public void SetScoreToSource(int score)
    {
        GameObject.Find("Score").GetComponent<ScoreManager>().SetScore(score);
    }
    public void ClearSourceScore()
    {
        GameObject.Find("Score").GetComponent<ScoreManager>().ClearScore();
    }
  /*
   * Poll keyboard for when the up arrow is pressed. If the player can jump
   * (is on the ground) then add force to the cached Rigidbody2D component.
   * Finally unset the canJump flag so the player has to wait to land before
   * another jump can be triggered.
   */
  private void Update()
  {
    if(Input.GetKeyDown(KeyCode.UpArrow))
    {
      if(canJump == true)
      {
        rigidbody2d.AddForce(new Vector2(0, 500));
        canJump = false;
      }
    }
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject i = new GameObject("Obstacle");
        }
  }

  /*
   * If the player has collided with the ground, set the canJump flag so that
   * the player can trigger another jump.
   */
  private void OnCollisionEnter2D(Collision2D other)
  {
    canJump = true;
  }
}
