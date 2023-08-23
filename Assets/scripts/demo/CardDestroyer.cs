using events;
using UnityEngine;

namespace demo {
    public class CardDestroyer : MonoBehaviour {
        public CardContainer container;
        public void OnCardDestroyed(CardPlayed evt) {
            container.DestroyCard(evt.card);
        }
    }
}
