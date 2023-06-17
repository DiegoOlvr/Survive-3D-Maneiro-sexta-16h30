using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject inimigo;
    
    void Start()
    {
        StartCoroutine(SpawnInimigo());

    }

    private IEnumerator SpawnInimigo()
    {
        // QUANTIDADE DE INIMIGOS QUE IRÃO APARECER
        var randomEnemies = Random.Range(1, 4);

        for (int i=0; i < randomEnemies; i++)
        {
            // LIMITE DO CAMPO, ONDE O INIMIGO TEM QUE CAIR
            var limite = Random.Range(-6.5f, 6.5f);
            // RESISTENCIA ALEATÓRIA
            var drag = Random.Range(0, 2);
            inimigo.GetComponent<Rigidbody>().drag = drag;
            //invocar ( quem ele tem que invocar, posição, rotação)
            Instantiate(inimigo, new Vector3(limite, 11, 0), Quaternion.identity);
        }

        yield return new WaitForSeconds(1f);

        yield return SpawnInimigo();
    }
}
