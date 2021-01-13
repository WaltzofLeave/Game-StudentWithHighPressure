using System.Collections.Generic;
using UnityEngine;

/*
 * Attached to the section so that everything will scroll sideways.
 * The player does not move in this game, the environment does.
 */
public class SectionScroller : MonoBehaviour
{
    public GameObject originalBar;
    List<GameObject> bars = new List<GameObject>();
    List<GameObject> activebars = new List<GameObject>();
    private PlayerController playerController;
    private GetandSetLevel level;
    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        level = GameObject.Find("Level").GetComponent<GetandSetLevel>();
        float origx = transform.position.x-45;
        int number = 5 + level.getlevel() < 7 ? 5 + level.getlevel() : 7;
        for (int i = 0; i < (number); i++)
        {
            float x = 20+ i * (80/(number))  -2 +Random.Range(0,4);
            GameObject t = Instantiate(originalBar);
            bars.Add(t);
            t.transform.position = new Vector3(origx +x,-3);//Maybe vector3
            activebars.Add(t);
        }
        
    }
    /*
     * Use the Transform component attached to the section game object and
     * translate it based on delta time.
     */
    private void Update()
  {

        float speed = -10;
    transform.Translate(new Vector2(speed, 0) * Time.deltaTime);
        //splayerController.AddScore();
        foreach (GameObject obj in bars)
        {
            
            if (obj)
            {
                obj.transform.Translate(new Vector2(speed, 0) * Time.deltaTime);
                if (activebars.Contains(obj))
                {
                    if(obj.transform.position.x +5 < GameObject.Find("Player").transform.position.x)
                    {
                        playerController.AddScore();
                        activebars.Remove(obj);
                    }
                }

            }
            else
            {
                if (activebars.Contains(obj))
                {
                    activebars.Remove(obj);
                }
            }
        }
    

  }
}
