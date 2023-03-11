using events;
using UnityEngine;

namespace demo {
    public class CardDestroyer : MonoBehaviour {
        public void OnCardDestroyed(CardPlayed evt) {
            Destroy(evt.card.gameObject);
        }
    }
}
