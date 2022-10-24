using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;

    int cantidad = 0;
    bool num1 = false;
    bool num2 = false;
    bool num3 = false;
    bool num4 = false;
    public string text;
    public Text textElement;
    float timer = 1f;
    public string seconds;
    public Text secondsText;
    public string description;
    public Text descriptionText;

    void Update()
    {
        timer = timer + Time.deltaTime;
        secondsText.text = "TIEMPO: " + Mathf.FloorToInt(timer);
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        if(controller.transform.position.x > 10 && controller.transform.position.x < 30 && controller.transform.position.z > -43 && controller.transform.position.z < -27){
            if(num1 == false){
                cantidad++;
                num1 = true;
            }
            
        }
        else if(controller.transform.position.x < -55 && controller.transform.position.x > -75 && controller.transform.position.z < -85 && controller.transform.position.z > -115){
            if(num2 == false){
                cantidad++;
                num2 = true;
            }
            description = "Estatua de Javier Cisneros";
        }

        else if(controller.transform.position.x < -140 && controller.transform.position.x > -285 && controller.transform.position.z < 140 && controller.transform.position.z > -5){
            if(num3 == false){
                cantidad++;
                num3 = true;
            }
            description = "Edificio Vazquez";

        }

        else if(controller.transform.position.x < -315 && controller.transform.position.x > -435 && controller.transform.position.z < 115 && controller.transform.position.z > -10){
            if(num4 == false){
                cantidad++;
                num4 = true;
            }
            description = "Edificio Carré";
        }

        else if(controller.transform.position.x < -135 && controller.transform.position.x > -433 && controller.transform.position.z < -70 && controller.transform.position.z > -410){
            // if(num5 == false){
            //     cantidad++;
            //     num5 = true;
            // }
            description = "Plaza de Mercado";
        }
        else if(controller.transform.position.x < 260 && controller.transform.position.x > 6 && controller.transform.position.z < 135 && controller.transform.position.z > -320){
            // if(num5 == false){
            //     cantidad++;
            //     num5 = true;
            // }
            description = "Estación de ferrocarril";
        }
        else{
            description = "";
        }
        textElement.text = "CANTIDAD: "+cantidad;
        descriptionText.text = description;
        Debug.Log("CANTIDAD: "+cantidad+"  "+controller.transform.position.x + "  " + controller.transform.position.z);
    }

}
