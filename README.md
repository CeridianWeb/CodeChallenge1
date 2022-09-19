# CodeChallenge1
## Week 1
**Requirements**
   1. Simulate a pack of cards
   2. 52 cards in a pack
   3. Suits Harts Club Diamond Spade - This order is important
   4. Ace 2 - 10 Jack Queen King
   5. Ace is low = 1
   6. Card should be able to write its own value i.e. 3H, JD etc
   7. PackOfCards should create the cards it needs for a full 52 card deck and be able to Deal() a single card at a time.
## Week 2
**Requirements**
   1. Add Basic Functions to the Pack Of Cards
      1. Shuffle() function that randomises the cards order when Deal() is called.
   2. Add some collections for cards that have different implementations ICardCollection.
      1. HandOfCards represents a players hand. Cards can be listed and a card at a position in the hand can be removed and played. 
      2. PileOfCards represents a pile of cards on a table.  New cards should be added to the top and removed newest first. (First In Last Out)