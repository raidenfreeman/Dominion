namespace Dominion.CardData
{
    public struct CommonCardData
    {
        public readonly int ID;
        public readonly int cost;
        public readonly string name;

        /// <summary>
        /// Creates an immutable ICard Data struct
        /// </summary>
        /// <param name="id">The card's ID</param>
        /// <param name="cost">The cost to buy the card</param>
        /// <param name="name">The name/title of the card</param>
        public CommonCardData(int id, int cost, string name)
        {
            ID = id;
            this.cost = cost;
            this.name = name;
        }

        public override string ToString()
        {
            return this.name + ", Cost: " + cost + ", ID: " + ID;
        }
    }
}
