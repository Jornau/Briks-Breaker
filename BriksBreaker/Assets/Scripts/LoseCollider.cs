using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour {

    [SerializeField] GameObject iFace;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ball")
        {
            iFace.SetActive(true);
        }
    }

    public void RestartLevel()
    {
        iFace.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }
}
