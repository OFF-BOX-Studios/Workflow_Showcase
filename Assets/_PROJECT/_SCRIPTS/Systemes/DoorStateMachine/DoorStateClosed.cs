//-----------------------------------------------------------
// (C) 2025 Abdulrhman Al-Ghamdi + Mishal Abdullah
//
// Summary:
// Represents the door being fully closed. 
// Waits for user input to transition to Opening state.
//
// Namespace: OFF_BOX_Studios
// Created by: Abdulrhman Al-Ghamdi + Mishal Abdullah
//-----------------------------------------------------------

using UnityEngine;

namespace OFF_BOX_Studios
{
    /// <summary>
    /// Handles logic for the door when it is fully closed.
    /// </summary>
    public class DoorStateClosed : IDoorState
    {
        public void EnterState(DoorController controller)
        {
            Debug.Log("Door is now closed.");
            controller.OpenProgress = 0f;
        }

        public void UpdateState(DoorController controller)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                controller.TransitionToState(controller.OpeningState);
            }
        }

        public void ExitState(DoorController controller)
        {
            Debug.Log("Door is leaving the closed state.");
        }
    }
}
