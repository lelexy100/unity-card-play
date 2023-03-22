namespace events {

    public class CardPlayed : CardEvent {
        public CardPlayed(CardWrapper card) : base(card) {
        }
    }
}
