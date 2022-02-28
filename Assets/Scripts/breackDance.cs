using UnityEngine;

public class breackDance : MonoBehaviour
{
    [SerializeField] private Animator theDancer;
    [SerializeField] private string breackDancing = "breackDance";

    void OnTriggerEnter(Collider other)
    {
        theDancer.Play(breackDancing, 0, 0.0f);
    }

}
