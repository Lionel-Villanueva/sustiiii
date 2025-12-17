using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CounterController : MonoBehaviour
{
    private TMP_Text text;
    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }
    private void Update()
    {
        text.text = "Score: " + GameManager.Instance.score.ToString();
    }
}
