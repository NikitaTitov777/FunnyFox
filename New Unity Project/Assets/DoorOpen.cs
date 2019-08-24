using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    private Animator doorAnim;

    void Start()
    {
        doorAnim = gameObject.GetComponent<Animator>();//подключаемся к компоненту Animator 
    }

    public void Open()
    {//меняем значение переменной на ParOpen на true 
        doorAnim.SetBool("ParOpen", true);
    }

    public void Close()
    {//меняем значение переменной на ParOpen на false 
        doorAnim.SetBool("ParOpen", false);

    }
}
