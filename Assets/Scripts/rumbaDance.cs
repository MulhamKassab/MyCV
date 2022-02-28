using UnityEngine;

public class rumbaDance : MonoBehaviour
{
    [SerializeField] private Animator theDancer;
    [SerializeField] private string rumbaDancing = "rumbaDance";

    void OnTriggerEnter(Collider other)
    {
        theDancer.Play(rumbaDancing, 0, 0.0f);
    }

}
