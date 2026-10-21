
using UnityEngine;

public class IniciarMaquina : MonoBehaviour
{
    public GameObject pelota;
    private bool iniciada = false;

    void Start()
    {
        pelota.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !iniciada)
        {
            pelota.SetActive(true);
            iniciada = true;
        }
    }
}
