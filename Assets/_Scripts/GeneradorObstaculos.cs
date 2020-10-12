using UnityEngine;

public class GeneradorObstaculos : MonoBehaviour
{
    public GameObject prefab;


    // Start is called before the first frame update
    void Start()
    {
        Generar();
    }

    void Generar()
    {
        Instantiate(prefab, this.transform);
        float tiempoAleatorio = Random.Range(1.5f, 3.5f);
        Invoke("Generar", tiempoAleatorio);
    }
}
