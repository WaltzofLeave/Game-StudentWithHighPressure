using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetandSetLevel : MonoBehaviour
{
    int level = 0;
    public int getlevel()
    {
        return level;
    }
    public void addlevel()
    {
        level++;
    }
    public void clearlevel()
    {
        level = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
