using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitching : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("myLifeJourney");
    }
}
