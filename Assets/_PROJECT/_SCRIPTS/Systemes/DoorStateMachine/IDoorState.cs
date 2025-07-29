//-----------------------------------------------------------
// (C) 2025 Abdulrhman Al-Ghamdi + Mishal Abdullah
//
// Summary:
// Interface that defines the contract for all door states.
// Each state must implement methods for entering, updating, and exiting.
//
// Namespace: OFF_BOX_Studios
// Created by: Abdulrhman Al-Ghamdi + Mishal Abdullah
//-----------------------------------------------------------

namespace OFF_BOX_Studios
{
    /// <summary>
    /// Interface for door states in the state machine.
    /// </summary>
    public interface IDoorState
    {
        void EnterState(DoorController controller);
        void UpdateState(DoorController controller);
        void ExitState(DoorController controller);
    }
}
