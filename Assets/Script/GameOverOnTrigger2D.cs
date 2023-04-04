using UnityEngine;
public class GameOverOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger game over")]
    [SerializeField] string triggeringTag;
    [SerializeField] KeyCode click;
    [SerializeField] ScoreField score;
    [SerializeField] int scorePerBlock = 1;
    [SerializeField] AccruciyField accruciyField;

    private void OnTriggerStay2D(Collider2D other) {
        
        if (other.tag == triggeringTag && enabled && Input.GetKey(click)) {
            Destroy(other.gameObject);
            score.AddNumber(scorePerBlock);
            accruciyField.AddSuccess(1);
            Debug.Log("Hit");
            // UnityEditor.EditorApplication.isPlaying = false;  # Error on editor 2021.3
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }

}
