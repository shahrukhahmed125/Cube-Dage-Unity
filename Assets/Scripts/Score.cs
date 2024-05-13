using TMPro;
using UnityEngine;
public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    public Transform player;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Z = "+player.position.z);
        scoreText.text = player.position.z.ToString("0");
    }
}
