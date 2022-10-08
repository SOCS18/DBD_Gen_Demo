using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    public GenRepairController genRepairControl;

    [SerializeField] private Animator anim;

    private bool isRunning;
    private bool isFixing;

    // Start is called before the first frame update
    void Start()
    {
        if (!anim)
            anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!genRepairControl.isReparingGen)
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");

            if (horizontal != 0 || vertical != 0)
                isRunning = true;
            else
                isRunning = false;

            if (isRunning)
                anim.SetBool("isRunning", true);
            else
                anim.SetBool("isRunning", false);
        }

        if (Input.GetKey(KeyCode.Mouse0))
            isFixing = true;
        else
            isFixing = false;

        if (isFixing)
            anim.SetBool("isFixing", true);
        else
            anim.SetBool("isFixing", false);
    }
}
