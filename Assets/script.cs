using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    int apple = 5;
    int banana = 6;

    double chinese = 3.5;
    float math = 8.5f;
    float english = 10;
    string student = "James";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(student + "'s total score =" + (chinese + math + english) );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
