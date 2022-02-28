using UnityEngine;

public class sillyDance : MonoBehaviour
{
    [SerializeField] private Animator theDancer;
    [SerializeField] private string startSillyDance = "sillyDance";

    void OnTriggerEnter(Collider other)
    {
        theDancer.Play(startSillyDance, 0, 0.0f);
    }

}
