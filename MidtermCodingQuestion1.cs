using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);

        if (right)
        {
            transform.position = transform.position + new Vector3(1, 0, 0) * Time.deltaTime;
        }

        if (left)
        {
            transform.position = transform.position + new Vector3(-1, 0, 0) * Time.deltaTime;
        }

        //Finish this code so that the character can move up and down, as well as left and right
    }
}
