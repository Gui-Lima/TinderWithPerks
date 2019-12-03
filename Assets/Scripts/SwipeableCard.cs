using System.Collections;
using System.Text;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SwipeableView;

public class SwipeableCard : SwipeableView.UISwipeableCard<Card>
{
        [SerializeField]
        private Image bg = default;

        [SerializeField]
        private CanvasGroup like = default;

        [SerializeField]
        private CanvasGroup nope = default;

        [SerializeField]
        private Text name = default;

        [SerializeField]
        private Text features = default;

        [SerializeField]
        private Image image = default;

       public override void UpdateContent(Card card)
        {
            bg.color = card.color;
            name.text = card.name;
            features.text = makeFeaturesText(card.features);
            like.alpha = 0;
            nope.alpha = 0;
            image.sprite = Resources.Load<Sprite>(card.imageName);
        }

        protected override void SwipingRight(float rate)
        {
            like.alpha = rate;
            nope.alpha = 0;
        }

        protected override void SwipingLeft(float rate)
        {
            nope.alpha = rate;
            like.alpha = 0;
        }

        private string makeFeaturesText(List<Feature> features){
            StringBuilder msg = new StringBuilder();
            foreach(Feature feature in features){
               msg.Append(feature.name);
               msg.Append("\n");
            }
            return msg.ToString();
        }
}