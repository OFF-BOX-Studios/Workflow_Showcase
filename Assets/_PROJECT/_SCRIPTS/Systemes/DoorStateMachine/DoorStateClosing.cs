//-----------------------------------------------------------
// (C) 2025 Abdulrhman Al-Ghamdi + Mishal Abdullah
//
// Summary:
// Represents the door while it is closing. 
// Decreases progress until fully closed, then transitions to Closed state.
//
// Namespace: OFF_BOX_Studios
// Created by: Abdulrhman Al-Ghamdi + Mishal Abdullah
//-----------------------------------------------------------

using UnityEngine;

namespace OFF_BOX_Studios
{
    /// <summary>
    /// Handles logic for the door while it is closing.
    /// </summary>
    public class DoorStateClosing : IDoorState
    {
        public void EnterState(DoorController controller)
        {
            Debug.Log("Door started closing.");
        }

        public void UpdateState(DoorController controller)
        {
            controller.OpenProgress -= Time.deltaTime;

            if (controller.OpenProgress <= 0f)
            {
                controller.TransitionToState(controller.ClosedState);
            }
        }

        public void ExitState(DoorController controller)
        {
            Debug.Log("Door finished closing.");
        }
    }
}
