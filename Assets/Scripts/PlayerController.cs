using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    public bool isAble;
    public GameObject prefab;
    public Vector3 newScale;

    void start()
    {
        isAble = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            // transform.position += new Vector3(0, 0, speed);
            transform.Translate(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            // transform.position += new Vector3(0, 0, -speed);
            transform.Translate(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles += new Vector3(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles += new Vector3(0, -rotationSpeed, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clon;
            clon = Instantiate(prefab);
            clon.transform.position = transform.position - new Vector3(0, 0, -1);
            clon.transform.localScale = newScale *= 1.1f;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Enabler Cube")
        {
            isAble = true;
        }
        else if (col.gameObject.name == "Disabler Cube")
        {
            isAble = false;
        }
    }
}
