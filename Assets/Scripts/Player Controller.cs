using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }


    void move()
    {
        int x = 0;
        int y = 0;
        if (Input.GetKey(KeyCode.W))
        {
            y += 1;
            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Up")){
                animator.SetTrigger("up");
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            y -= 1;
            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Down"))
            {
                animator.SetTrigger("down");
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            x += 1;
            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Right"))
            {
                animator.SetTrigger("right");
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            x -= 1;
            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Left"))
            {
                animator.SetTrigger("left");
            }
        }

        transform.position = transform.position + new Vector3(x * speed * Time.deltaTime, y * speed * Time.deltaTime);
    }
}
