using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene02Controller : MonoBehaviour, Subscriber, ISceneController
{
    [SerializeField] private SwipeableViewScener swipeableView;
    [SerializeField] private Hint hint;
    [SerializeField] private Score scoreText;
    private Deck deck;
    private int CurrentCard = 0;
    private List<string> objetivos = new List<string>();
    private bool endScene = false;

    private void Awake(){
        this.objetivos = new List<string>();
        SceneMaker.setLevelAndroid("Level1.json");
        this.deck = SceneMaker.getCurrentdeck();
        ScoreManager.Instance.AddSub(this);
    }

    void Start()
    {
        swipeableView.UpdateData(this.deck.cards);
        objetivos.Add("Animes");
        objetivos.Add("Videogames");
        objetivos.Add("Cachorros");
        hint.InitializeHint(objetivos, 3);
        StartCoroutine(WaitXSeconds(5));
    }

      public void win(){
        GameObject go = GameObject.Find("Win");
        LogoFadeIn other = (LogoFadeIn) go.GetComponent(typeof(LogoFadeIn));
        other.startFading(MovingTextManager.FadeType.In);
        endScene = true;
    }

    public void lose(){
        GameObject go = GameObject.Find("Lose");
        LogoFadeIn other = (LogoFadeIn) go.GetComponent(typeof(LogoFadeIn));
        other.startFading(MovingTextManager.FadeType.In);
        endScene = true;
    }


    public void Notify(string message){
        if(message == "right"){
            Debug.Log(this.deck.cards[CurrentCard].features);
            this.scoreText.addScore(ScoreManager.Instance.CalculateScore(this.deck.cards[CurrentCard].features, this.objetivos, "like"));
        }
        else if(message == "left"){
            this.scoreText.addScore(ScoreManager.Instance.CalculateScore(this.deck.cards[CurrentCard].features, this.objetivos, "nope"));
        }
        this.CurrentCard++;
        if(CurrentCard == deck.size){
            if(this.scoreText.getScore() > 0){
                win();
            }
            else{
                lose();
            }
            endScene = true;
        }
    }

    public IEnumerator WaitXSeconds(int seconds){
        yield return new WaitForSeconds(seconds);
        MovingTextManager.Instance.FadeText("ObjetivoText", MovingTextManager.FadeType.Out);
    }
}
