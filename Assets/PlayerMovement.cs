using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;

    int cantidad = 0;
    bool num1 = false;
    bool num2 = false;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        if(controller.transform.position.x > 15 && controller.transform.position.x < 25 && controller.transform.position.z > -38 && controller.transform.position.z < -30){
            if(num1 == false){
                cantidad++;
                num1 = true;
            }
            Debug.Log("Estás dentro");
        }
        if(controller.transform.position.x > 0 && controller.transform.position.x < 5 && controller.transform.position.z > 0 && controller.transform.position.z < 5){
            if(num2 == false){
                cantidad++;
                num2 = true;
            }
            Debug.Log("Estás dentro");
        }
        Debug.Log("CANTIDAD: "+cantidad+"  "+controller.transform.position.x + "  " + controller.transform.position.z);
    }

}
