using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    private GetandSetLevel level;
    public void OnNextClicked()
    {
        level = GameObject.Find("Level").GetComponent<GetandSetLevel>();
        level.addlevel();
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
        //Application.LoadLevel("Game");
    }
    // Start is called before the first frame update
    void Start()
    {
        level = GameObject.Find("Level").GetComponent<GetandSetLevel>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
