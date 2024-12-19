using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TechXR.Core.Sense;

public class ControlsManager : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    public SenseController senseController;
    bool TeleportMove = true;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SenseInput.GetButtonDown(ButtonName.D))
        {
            animator.Play("open");
        }

        else if(SenseInput.GetButtonUp(ButtonName.D))
        {
            animator.Play("close");
        }

        if (SenseInput.GetButtonDown(ButtonName.C))
        {
            senseController.ToggleTeleportMovement(!TeleportMove);
            senseController.ToggleJoystickMovement(TeleportMove);
            TeleportMove = !TeleportMove;
        }
    }
}
 