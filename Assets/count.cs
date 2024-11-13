using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float timer = 90; 
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI endtext;
    public Image gamerover;
    public TextMeshProUGUI scoretext;
    public AudioSource music;
    private bool running = true;
    public TextMeshProUGUI wintext;
    public Image win; 
    private int score = 0;
    void Start()
    {
        ResetUI();
        score_update();
    }
    void Update()
    {
        if (running && timer > 0)
        {
            timer -= Time.deltaTime;
            updatetimer(timer);
        }
        else if (running)
        {
            endG(false);
        }
    }

    public void increment_score(int points)
    {
        score= score+points;
        score_update();
    }

    void score_update()
    {
        scoretext.text = "Score: " + score.ToString();
    }

    private void endG(bool victory)
    {
        running = false;
        Time.timeScale = 0;

        if (victory)
        {
            if (music != null) music.Stop();
            win.color = new Color(0, 1, 0, 1); 
            wintext.text = $"Congrats! This is your best Halloween ever and your candy score is: {score}";
        }
        else
        {
            gamerover.color = new Color(1, 0, 0, 1); 
            endtext.text = $"I do not think this is your Best Halloween Ever Loool.\nYour Final score is {score}";
        }
    }
   public void TriggerVictory()
    {
        endG(true);
    }
    private void updatetimer(float timeToDisplay)
    {
        int minutes = Mathf.FloorToInt(timeToDisplay / 60);
        int seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = $"{minutes:00}:{seconds:00}";
    }

    private void ResetUI()
    {
        endtext.text = "";
        gamerover.color = new Color(1, 0, 0, 0);
        win.color = new Color(0, 1, 0, 0);
    }
}
