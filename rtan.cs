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
            toward *= -1;   // ���콺�� ������ towrad, direction ���� -1�� �ٲ۴�.
            direction *= -1;    // direction *= -1; = ���� ���� -1�� ���Ѵ�. �� ���콺�� Ŭ���ϸ� ��ȣ�� �ٲ۴�. 
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
