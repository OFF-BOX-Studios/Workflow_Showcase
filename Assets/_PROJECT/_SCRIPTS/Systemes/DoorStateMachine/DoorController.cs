//-----------------------------------------------------------
// (C) 2025 Abdulrhman Al-Ghamdi + Mishal Abdullah
//
// Summary:
// A MonoBehaviour that manages door states using a state machine. 
// Handles transitions and applies smooth Y-axis rotation.
//
// Namespace: OFF_BOX_Studios
// Created by: Abdulrhman Al-Ghamdi + Mishal Abdullah
//-----------------------------------------------------------

using UnityEngine;

namespace OFF_BOX_Studios
{
    /// <summary>
    /// Manages the door state machine and applies rotation based on progress.
    /// </summary>
    public class DoorController : MonoBehaviour
    {
        [SerializeField] private float maxOpenProgress = 3f;
        [SerializeField] private Transform doorTransform;

        public float MaxOpenProgress => maxOpenProgress;
        public float OpenProgress { get; set; }

        public IDoorState CurrentState { get; private set; }

        public IDoorState ClosedState { get; private set; }
        public IDoorState OpeningState { get; private set; }
        public IDoorState OpenState { get; private set; }
        public IDoorState ClosingState { get; private set; }

        private Quaternion closedRotation;
        private Quaternion openRotation;

        private void Awake()
        {
            ClosedState = new DoorStateClosed();
            OpeningState = new DoorStateOpening();
            OpenState = new DoorStateOpen();
            ClosingState = new DoorStateClosing();
        }

        private void Start()
        {
            closedRotation = Quaternion.Euler(0, 0, 0);
            openRotation = Quaternion.Euler(0, 90, 0);

            TransitionToState(ClosedState);
        }

        private void Update()
        {
            CurrentState.UpdateState(this);

            float t = Mathf.Clamp01(OpenProgress / MaxOpenProgress);
            if (doorTransform != null)
                doorTransform.rotation = Quaternion.Lerp(closedRotation, openRotation, t);
        }

        public void TransitionToState(IDoorState newState)
        {
            if (CurrentState != null)
                CurrentState.ExitState(this);

            CurrentState = newState;
            CurrentState.EnterState(this);
        }
    }
}
