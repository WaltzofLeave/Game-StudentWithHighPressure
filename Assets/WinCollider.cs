using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = -10;
        transform.Translate(new Vector2(speed, 0) * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelUp");
    }
}
