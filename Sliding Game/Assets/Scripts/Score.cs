using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{

    public Transform player;
    public TMP_Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0"); //convert float into a string and display it on the UI
    }
}
