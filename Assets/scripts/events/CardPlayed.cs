namespace events {
    public class CardPlayed {
        public readonly CardWrapper card;

        public CardPlayed(CardWrapper card) {
            this.card = card;
        }
    }
}
