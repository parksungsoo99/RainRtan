using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rtan : MonoBehaviour
{
    float direction = 0.05f;
    float toward = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            toward *= -1;   // 마우스를 누르면 towrad, direction 값을 -1로 바꾼다.
            direction *= -1;    // direction *= -1; = 현재 값에 -1을 곱한다. 즉 마우스를 클릭하면 부호를 바꾼다. 
        }

        if (transform.position.x > 2.8f)
        {
            direction = -0.05f;
            toward = -1f;

        }
        if (transform.position.x < -2.8f)
        {
            direction = 0.01f;
            toward = 1f;
        }

        transform.localScale = new Vector3(toward, 1, 1);
        transform.position += new Vector3(direction, 0, 0);
    }
}
