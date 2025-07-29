//-----------------------------------------------------------
// (C) 2025 Abdulrhman Al-Ghamdi + Mishal Abdullah
//
// Summary:
// Represents the door while it is opening. 
// Increases progress until fully open, then transitions to Open state.
//
// Namespace: OFF_BOX_Studios
// Created by: Abdulrhman Al-Ghamdi + Mishal Abdullah
//-----------------------------------------------------------

using UnityEngine;

namespace OFF_BOX_Studios
{
    /// <summary>
    /// Handles logic for the door while it is opening.
    /// </summary>
    public class DoorStateOpening : IDoorState
    {
        public void EnterState(DoorController controller)
        {
            Debug.Log("Door started opening.");
        }

        public void UpdateState(DoorController controller)
        {
            controller.OpenProgress += Time.deltaTime;

            if (controller.OpenProgress >= controller.MaxOpenProgress)
            {
                controller.TransitionToState(controller.OpenState);
            }
        }

        public void ExitState(DoorController controller)
        {
            Debug.Log("Door finished opening.");
        }
    }
}
