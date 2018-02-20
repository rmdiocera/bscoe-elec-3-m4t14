using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 currentRotation;
    // Use this for initialization
    void Start()
    {
        currentRotation = transform.localRotation.eulerAngles;

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
        //transform.rotation = Quaternion.LookRotation(Vector3.forward);


        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + -Camera.main.transform.right * Time.deltaTime * 3f;
            //Mathf.Clamp(transform.localRotation, -45f, 45f);
            transform.Rotate(Vector3.forward * Time.deltaTime * 50f);


        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + Camera.main.transform.right * Time.deltaTime * 3f;
            transform.Rotate(Vector3.back * Time.deltaTime * 50f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + Camera.main.transform.up * Time.deltaTime * 3f;
            //transform.Rotate(Vector3.left * Time.deltaTime * 150f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + -Camera.main.transform.up * Time.deltaTime * 3f;
            // transform.Rotate(Vector3.right * Time.deltaTime * 150f);
        }

    }




}
