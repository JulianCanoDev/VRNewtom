using UnityEngine;
using TMPro;

public class PointsCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    private int points = 0;

    public void AddPoints(int targetPoints) => points += targetPoints;
    public int GetPoints() => points;
    public void ShowScore() => scoreText.text = $"Score {GetPoints()}";
}
