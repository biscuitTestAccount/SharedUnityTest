using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }
        // hi there
        int iter = 0;
        iter++;
        //I changed something
        //and this
        //and this-chanee
        while (iter<10)
        {
            iter++;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
