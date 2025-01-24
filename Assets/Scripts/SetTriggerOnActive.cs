using UnityEngine;

public class SetTriggerOnActive : StateMachineBehaviour
{
    // Name of the trigger to set
    public string triggerName;

    // Called when the state is entered
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (!string.IsNullOrEmpty(triggerName))
        {
            animator.SetTrigger(triggerName);
        }
        else
        {
            Debug.LogWarning("Trigger name is not set in SetTriggerOnActive StateMachineBehaviour.");
        }
    }
}