namespace events {
    
    public class CardEvent {
        public readonly CardWrapper card;

        public CardEvent(CardWrapper card) {
            this.card = card;
        }
    }
}
