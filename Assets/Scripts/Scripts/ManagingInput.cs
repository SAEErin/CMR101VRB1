using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagingInput : MonoBehaviour
{

    public ChangeSize cc;
    // Start is called before the first frame update
    void Start()
    {
        //Thisisthestart
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space key was pressed");
            cc.MoveLeft();
          
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            print("A has been pressed");
            cc.MoveRight();
            
        }    
    }
}
