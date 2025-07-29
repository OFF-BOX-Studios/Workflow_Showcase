//-----------------------------------------------------------
// (C) 2025 Abdulrhman Al-Ghamdi + Mishal Abdullah
//
// Summary:
// Represents the door when fully open. 
// Waits for user input to start closing.
//
// Namespace: OFF_BOX_Studios
// Created by: Abdulrhman Al-Ghamdi + Mishal Abdullah
//-----------------------------------------------------------

using UnityEngine;

namespace OFF_BOX_Studios
{
    /// <summary>
    /// Handles logic for the door when fully open.
    /// </summary>
    public class DoorStateOpen : IDoorState
    {
        public void EnterState(DoorController controller)
        {
            Debug.Log("Door is fully open.");
        }

        public void UpdateState(DoorController controller)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                controller.TransitionToState(controller.ClosingState);
            }
        }

        public void ExitState(DoorController controller)
        {
            Debug.Log("Door is leaving the open state.");
        }
    }
}
