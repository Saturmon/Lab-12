using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tecla : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    public int direccionx;
    public int direcciony;
    private Rigidbody2D _compRigidbody;
    private void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d") == true)
        {
            direccionx = 1;
        }
        else if (Input.GetKey("a") == true)
        {
            direccionx = -1;
        }
        else if(Input.GetKey("d") != true)
        {
            direccionx = 0;
        }
        else if (Input.GetKey("a") != true)
        {
            direccionx = 0;
        }


        if (Input.GetKey("w") == true)
        {
            direcciony = 1;
        }
        if (Input.GetKey("s") == true)
        {
            direcciony = -1;
        }
        
        _compRigidbody.velocity = new Vector2(speed * direccionx, direcciony * speed);
        if (Input.GetKey("w") != true)
        {
            direcciony = 0;
        }
        if (Input.GetKey("s") != true)
        {
            direcciony = 0;
        }
    }

}
