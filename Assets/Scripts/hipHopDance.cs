using UnityEngine;

public class hipHopDance : MonoBehaviour
{
    [SerializeField] private Animator theDancer;
    [SerializeField] private string hipHopDancing = "hipHopDance";

    void OnTriggerEnter(Collider other)
    {
        theDancer.Play(hipHopDancing, 0, 0.0f);
    }

}
