using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void StartGlobalCoroutine(System.Collections.IEnumerator coroutine)
    {
        StartCoroutine(coroutine);
    }
}
