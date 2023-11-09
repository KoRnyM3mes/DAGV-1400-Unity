using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayEvent;
    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempID = other.GetComponent<IdContainerBehavior>();
        if (tempID == null)
            yield break;

        var otherID = tempID.idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayEvent.Invoke();
        }
    }
}   