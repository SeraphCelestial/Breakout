using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnBricks : MonoBehaviour
{
    public GameObject redBrick;
    public GameObject orangeBrick;
    public GameObject greenBrick;
    public GameObject yellowBrick;
    // Start is called before the first frame update
    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        for (float x = -4.45f; x <= 4.22f; x += 0.78f)
        {
            Vector3 posRedBrick = new Vector3(x, 2.1f, 0);
            Instantiate(redBrick, posRedBrick, Quaternion.identity);
            posRedBrick = new Vector3(x, 1.82f, 0);
            Instantiate(redBrick, posRedBrick, Quaternion.identity);
        }
        for (float x = -4.45f; x <= 4.22f; x += 0.78f)
        {
            Vector3 posOrangeBrick = new Vector3(x, 1.54f, 0);
            Instantiate(orangeBrick, posOrangeBrick, Quaternion.identity);
            posOrangeBrick = new Vector3(x, 1.26f, 0);
            Instantiate(orangeBrick, posOrangeBrick, Quaternion.identity);
        }
        for (float x = -4.45f; x <= 4.22f; x += 0.78f)
        {
            Vector3 posGreenBrick = new Vector3(x, 0.98f, 0);
            Instantiate(greenBrick, posGreenBrick, Quaternion.identity);
            posGreenBrick = new Vector3(x, 0.70f, 0);
            Instantiate(greenBrick, posGreenBrick, Quaternion.identity);
        }
        for (float x = -4.45f; x <= 4.22f; x += 0.78f)
        {
            Vector3 posYellowBrick = new Vector3(x, 0.42f, 0);
            Instantiate(yellowBrick, posYellowBrick, Quaternion.identity);
            posYellowBrick = new Vector3(x, 0.14f, 0);
            Instantiate(yellowBrick, posYellowBrick, Quaternion.identity);
        }
    }
}
