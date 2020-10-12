using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    float velocidadX;

    // Start is called before the first frame update
    void Start()
    {
        velocidadX = 0.05f;
        float aleatorioY = Random.Range(-1.4f, 1.4f);
        transform.Translate(0, aleatorioY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-velocidadX, 0, 0);

        // transform.position -> Posicion global (al depender de un padre, ignora su posicion).
        // transform.localPosition -> Posicion local con respecto al padre.
        if (transform.localPosition.x <= -10f)
        {
            Destroy(gameObject);
        }
    }
}
