using UnityEngine;

public class SetTriggerOnComplete : StateMachineBehaviour
{
    // Name of the trigger to set
    public string triggerName;

    // Flag to ensure the trigger is only set once when the state is complete
    private bool triggerSet;

    // Called when the animation state updates
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Check if the animation state is complete (normalizedTime >= 1.0)
        if (stateInfo.normalizedTime >= 1.0f && !triggerSet)
        {
            if (!string.IsNullOrEmpty(triggerName))
            {
                animator.SetTrigger(triggerName);
                triggerSet = true; // Prevent setting the trigger multiple times
            }
            else
            {
                Debug.LogWarning("Trigger name is not set in SetTriggerOnComplete StateMachineBehaviour.");
            }
        }
    }

    // Reset the flag when exiting the state
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        triggerSet = false; // Reset the flag for the next time this state is entered
    }
}
